using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Threading.Tasks;
using URL_Shortener.DatabaseContexts;
using URL_Shortener.Models;
using URL_Shortener.Services;
using URL_Shortener.HelperClasses;

namespace URL_Shortener.Controllers
{
    //GET: .../URL
    public class URLController : Controller
    {
        private readonly URLService _urlService;
        private readonly URLContext _urlContext;
        private readonly MailService _mailService;

        public URLController(URLService urlService, URLContext urlContext, MailService mailService)
        {
            _urlService = urlService;
            _urlContext = urlContext;
            _mailService = mailService;
        }

        //GET: .../URL/About
        public IActionResult About()
        {
            return View();
        }

        //GET: .../Index or .../URL/Index (Due to default routing in startup)
        public IActionResult Index()
        {
            var enterUrlModel = new EnterURLModel() { UrlData = null, HostName = URLData.GetHostname(Request) };
            var UserUrls = _urlService.GetUserUrls(_urlContext, HttpContext);

            if(UserUrls.Count() >= 5)
            {
                UserUrls = UserUrls.Skip(UserUrls.Count() - 5); //Takes last 5 only
            }

            enterUrlModel.UserUrls = UserUrls;

            return View("EnterURL", enterUrlModel);
        }

        //GET: .../{ShortenedID} 
        [Route("{ShortenedID}")] //Different controller to return the full url rather than overwriting the main index controller
        public IActionResult ReturnBaseURL(string ShortenedID)
        {
            if (string.IsNullOrEmpty(ShortenedID))
            {
                return null;
            }
            else
            {
                try
                {
                    URL fullURL = _urlService.ReturnUrlModel(_urlContext, ShortenedID);

                    if(fullURL != null && fullURL.BaseURL != null)
                    {
                        _urlService.UpdateUrlUsers(_urlContext, Request, fullURL); //Updating user set for this URL and URL stats

                        return Redirect(fullURL.BaseURL);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch(InvalidOperationException) //No elements in db for that shortened ID
                {
                    return NotFound();
                }
            }
        }

        //POST: .../DeleteURL
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteURL(string shortenedID, string pageType)
        {
            Console.WriteLine($"Request to delete URL with shortened ID of {shortenedID} at {DateTime.Now} from {HttpContext.Connection.RemoteIpAddress}");

            //Remove URL from Database
            await _urlService.RemoveURL(_urlContext, shortenedID);
            
            switch(pageType) //Specifies which page to return to once the data is updated
            {
                case "IndexList":
                    return RedirectToAction("index");
                case "FullList":
                    return RedirectToAction("url-list");
                default:
                    return Ok();
            }
        }

        //POST: .../UploadURL
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UploadURL(URL url)
        {
            if (!ModelState.IsValid)
            {
                var enterURLModel = new EnterURLModel() { UrlData = url, HostName = null };
                var UserUrls = _urlService.GetUserUrls(_urlContext, HttpContext);

                if (UserUrls.Count() >= 5)
                {
                    UserUrls = UserUrls.Skip(UserUrls.Count() - 5); //Takes last 5 only
                }

                enterURLModel.UserUrls = UserUrls;

                return View("EnterURL", enterURLModel);
            }

            url.ExternalIP = HttpContext.Connection.RemoteIpAddress.ToString();

            await _urlService.AddURL(_urlContext, url, Request);
            
            var enterUrlModel = new EnterURLModel() { UrlData = url, UserUrls = _urlService.GetUserUrls(_urlContext, HttpContext), HostName = URLData.GetHostname(Request)};

            return View("DisplayURL", enterUrlModel);
        }

        //GET: .../url-list
        [ActionName("url-list")]
        [Route("url/{action}")]
        public IActionResult UrlList()
        {
            var enterURLModel = new EnterURLModel() { UrlData = null, UserUrls = _urlService.GetUserUrls(_urlContext, HttpContext), HostName = null };

            return View("DisplayURL", enterURLModel);
        }

        //GET: .../ContactMe
        public IActionResult ContactMe()
        {
            ViewData["Valid"] = "";

            return View("ContactPage", new ContactMeModel());
        }

        //POST: .../SubmitContactForm
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitContactForm(ContactMeModel contactData)
        {
            ViewData["Valid"] = "";

            if (ModelState.IsValid)
            {
                _mailService.SendMail(contactData);
                ViewData["Valid"] = "true";
                return View("ContactPage", new ContactMeModel());
            }   

            return View("ContactPage", contactData);
        }
    }
}

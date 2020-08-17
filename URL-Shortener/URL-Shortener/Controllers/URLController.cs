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
    //PATH: .../URL
    public class URLController : Controller
    {
        private readonly URLService _urlService;
        private readonly URLContext _urlContext;

        public URLController(URLService urlService, URLContext urlContext)
        {
            _urlService = urlService;
            _urlContext = urlContext;
        }

        //PATH: .../URL/GetData
        public IEnumerable<URL> GetData()
        {
            return _urlService.GetAllURLs(_urlContext);
        }

        //PATH: .../URL/Test
        public IActionResult Test()
        {
            var e = new URL { BaseURL = "ddhello" };

            return View(e);
        }

        //PATH: .../URL/About
        public IActionResult About(string t)
        {
            Console.WriteLine(t);
            return View();
        }

        //PATH: .../Index or .../URL/Index (Due to default routing in startup)
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

        //Path: .../{ShortenedID} 
        [Route("{ShortenedID}")] //Different controller to return the full url rather than overloading the main index controller
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
                    string fullURL = _urlContext.UrlSet.Where(x => x.ShortenedIdentifier == ShortenedID).First().BaseURL;

                    //Log to console
                    Console.WriteLine(ShortenedID + fullURL); //DO MORE HERE

                    return Redirect(fullURL);
                }
                catch(InvalidOperationException) //No elements in db for that shortened ID
                {
                    return NotFound();
                }
            }
        }

        [HttpPost]
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
                    UrlList();
                    return RedirectToAction("url-list");
                default:
                    return Ok();
            }
        }

        [HttpPost]
        public async Task<IActionResult> UploadURL(URL url) //Add error checking / validation for the url.baseurl being a fqdn
        {
            url.ExternalIP = HttpContext.Connection.RemoteIpAddress.ToString();

            await _urlService.AddURL(_urlContext, url);
            
            var enterUrlModel = new EnterURLModel() { UrlData = url, UserUrls = _urlService.GetUserUrls(_urlContext, HttpContext), HostName = URLData.GetHostname(Request)};

            return View("DisplayURL", enterUrlModel);
        }

        [ActionName("url-list")]
        [Route("url/{action}")]
        public IActionResult UrlList()
        {
            var enterURLModel = new EnterURLModel() { UrlData = null, UserUrls = _urlService.GetUserUrls(_urlContext, HttpContext), HostName = null };

            return View("DisplayURL", enterURLModel);
        }

        public IActionResult ContactMe()
        {
            return View("ContactPage");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}

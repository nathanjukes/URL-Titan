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
        public IActionResult About()
        {
            return View();
        }
        
        public async Task<IActionResult> Index()
        {
            var enterUrlModel = new EnterURLModel() { UrlData = null, UserUrls = _urlService.GetUserUrls(_urlContext, HttpContext), HostName = URLData.GetHostname(Request) };

            return View("EnterURL", enterUrlModel);
        }

        [HttpPost]
        public async Task<IActionResult> UploadURL(URL url)
        {
            url.ExternalIP = HttpContext.Connection.RemoteIpAddress.ToString();

            await _urlService.AddURL(_urlContext, url);
            
            var enterUrlModel = new EnterURLModel() { UrlData = url, UserUrls = _urlService.GetUserUrls(_urlContext, HttpContext), HostName = URLData.GetHostname(Request)};

            return View("DisplayURL", enterUrlModel);
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

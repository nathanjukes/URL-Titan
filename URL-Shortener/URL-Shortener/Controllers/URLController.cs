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

        [HttpPost]
        public ActionResult UploadURL(URL url)
        {
            Console.WriteLine(url.BaseURL + url.Id);
            ViewData["Domain"] = URLData.GetHostname(Request);

            return View("DisplayURL", url);
        }
    }
}

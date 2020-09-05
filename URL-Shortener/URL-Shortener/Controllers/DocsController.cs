using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using URL_Shortener.HelperClasses;
using URL_Shortener.Models;

namespace URL_Shortener.Controllers
{
    public class DocsController : Controller
    {
        //GET: .../Index
        public IActionResult Index()
        {
            return RedirectToAction("index", "api");
        }

        //GET: .../Shorten-url
        [ActionName("shorten-url")]
        public IActionResult ShortenUrl()
        {
            return View("ShortenUrl", new DocsModel() { HostName = URLData.GetHostname(Request) });
        }

        //GET: .../Get-full-url
        [ActionName("get-full-url")]
        public IActionResult GetFullUrl()
        {
            return View("GetFullURL", new DocsModel() { HostName = URLData.GetHostname(Request) });
        }

        //GET: .../Shorten-collection
        [ActionName("shorten-collection")]
        public IActionResult ShortenCollection()
        {
            return View("ShortenCollection", new DocsModel() { HostName = URLData.GetHostname(Request) });
        }

        //GET: .../Get-url-uses
        [ActionName("get-url-uses")]
        public IActionResult GetUrlUses()
        {
            return View();
        }

        //GET: .../Get-url-stats
        [ActionName("get-url-stats")]
        public IActionResult GetUrlStats()
        {
            return View();
        }


    }
}

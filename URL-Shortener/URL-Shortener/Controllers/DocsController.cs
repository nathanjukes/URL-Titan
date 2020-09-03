﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            return View("About");
        }

        //GET: .../Get-full-url
        [ActionName("get-full-url")]
        public IActionResult GetFullUrl()
        {
            return View();
        }

        //GET: .../Shorten-collection
        [ActionName("shorten-collection")]
        public IActionResult ShortenCollection()
        {
            return View();
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

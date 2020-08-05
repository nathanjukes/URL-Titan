using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using URL_Shortener.DatabaseContexts;
using URL_Shortener.Models;

namespace URL_Shortener.Controllers
{
    //PATH: .../Home
    public class HomeController : Controller
    {
        private readonly URLContext _urlContext;

        public HomeController(URLContext urlContext)
        {
            _urlContext = urlContext;
        }

        //PATH: .../Home/Index
        public string Index()
        {
            return "dd";
        }

        //PATH: .../Home/Test
        public int[] Test()
        {
            _urlContext.Add(new URL{ BaseURL = "dd" });
            _urlContext.SaveChanges();

            return new int[] { 5, 2 };
        }

        //PATH: .../Home/About
        public IActionResult About()
        {
            return View();
        }
    }
}
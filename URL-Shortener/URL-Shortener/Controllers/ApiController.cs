using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace URL_Shortener.Controllers
{
    public class ApiController : Controller
    {
        // GET: ApiController
        public ActionResult Index()
        {
            return View("About");
        }

        [ValidateAntiForgeryToken]
        public IActionResult About()
        {
            return View();
        }
    }
}

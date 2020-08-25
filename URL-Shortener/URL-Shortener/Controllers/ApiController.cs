using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using URL_Shortener.DatabaseContexts;
using URL_Shortener.HelperClasses;
using URL_Shortener.Models;
using URL_Shortener.Services;

namespace URL_Shortener.Controllers
{
    public class ApiController : Controller
    {
        private readonly URLContext _urlContext;
        private readonly URLService _urlService;

        public ApiController(URLContext urlContext, URLService urlService)
        {
            _urlContext = urlContext;
            _urlService = urlService;
        }

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

        [HttpPost]
        public async Task<IActionResult> ShortenURL(string BaseURL)
        {
            if(!Uri.IsWellFormedUriString(BaseURL, UriKind.Absolute))
            {
                return StatusCode(400); //Bad Request - Input must be of type URL
            }

            var urlToAdd = new URL() { BaseURL = BaseURL };

            try //Attempts to add URL to DB
            {
                await _urlService.AddURL(_urlContext, urlToAdd);
            }
            catch(Exception postShortURLError)
            {
                Console.WriteLine($"{postShortURLError} at {DateTime.Now}");
                return StatusCode(500); //Internal Server Error
            }
            
            if(!string.IsNullOrEmpty(urlToAdd.ShortenedIdentifier)) //Final check to see if the action is about to return a null value
            {
                var returnObject = new { shortenedURL = URLData.GetHostname(Request) + urlToAdd.ShortenedIdentifier }; //Creates object with all of the data needing to be returned
                var returnData = JsonConvert.SerializeObject(returnObject); //Serializes the object (Second layer to prevent returning a pure object)

                return Ok(returnData);
            }
            else
            {
                return StatusCode(500); //Internal Server Error
            }     
        }

        //Shorten a URL
        //Return a URL based on a given ID / URL
        //Shorten a collection of URLs
        //Return amount of uses for the given shortened url
        //Return all url stats
    }
}

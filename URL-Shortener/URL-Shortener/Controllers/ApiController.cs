using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Tls;
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
        public IActionResult Index()
        {
            return View("Api");
        }

        public IActionResult About()
        {
            return View();
        }

        //POST: .../ShortenURL
        [HttpPost]
        [ValidateAntiForgeryToken]
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
                var returnObject = new { shortenedUrl = URLData.GetHostname(Request) + urlToAdd.ShortenedIdentifier }; //Creates object with all of the data needing to be returned
                string returnData = JsonConvert.SerializeObject(returnObject); //Serializes the object (Second layer to prevent returning a pure object)

                return Ok(returnData);
            }
            else
            {
                return StatusCode(500); //Internal Server Error
            }     
        }

        //GET: .../GetFullUrl
        [HttpGet]
        public IActionResult GetFullUrl(string ShortURL)
        {
            if(string.IsNullOrEmpty(ShortURL))
            {
                return StatusCode(400); //Bad request
            }
            else
            {
                var splitUrl = ShortURL.Split('/');
                string shortId = splitUrl[splitUrl.Length - 1];

                string baseUrl = _urlService.ReturnBaseUrl(_urlContext, shortId);

                if(baseUrl != null && baseUrl != "404")
                {
                    var returnObject = new { baseUrl = baseUrl, shortenedUrl = ShortURL };
                    string returnData = JsonConvert.SerializeObject(returnObject);

                    return Ok(returnData);
                }
                else if(baseUrl == "404")
                {
                    return StatusCode(404);
                }
                else
                {
                    return StatusCode(500);
                }
            }
        }

        //POST: .../ShortenCollection
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ShortenCollection([FromBody] IEnumerable<string> UrlList)
        {
            if (UrlList == null || UrlList.Count() == 0) return StatusCode(400);

            List<string> returnList = new List<string>();

            foreach(var baseUrl in UrlList)
            {
                if(Uri.IsWellFormedUriString(baseUrl, UriKind.Absolute))
                {
                    var urlToAdd = new URL { BaseURL = baseUrl };
                    await _urlService.AddURL(_urlContext, urlToAdd);

                    returnList.Add(URLData.GetHostname(Request) + urlToAdd.ShortenedIdentifier);
                }
                else
                {
                    returnList.Add("");
                }
            }

            return Ok(returnList);
        }

        [HttpGet]
        public IActionResult GetUrlUses(string ShortURL)
        {
            if (string.IsNullOrEmpty(ShortURL)) return StatusCode(400);

            string[] splitUrl = ShortURL.Split('/');
            string shortenedID = splitUrl[splitUrl.Length - 1];

            try
            {
                URL url = _urlContext.UrlSet.Single(x => x.ShortenedIdentifier == shortenedID);

                var returnObject = new { useCount = _urlService.GetUrlTotalUses(_urlContext, url), baseUrl = _urlService.ReturnBaseUrl(_urlContext, shortenedID), shortenedUrl = ShortURL };
                string returnData = JsonConvert.SerializeObject(returnObject);

                return Ok(returnObject);
            }
            catch(InvalidOperationException)
            {
                return StatusCode(400);
            }
        }

        [HttpGet]
        public IActionResult GetUrlStats(string ShortURL)
        {
            if (string.IsNullOrEmpty(ShortURL)) return StatusCode(400);

            string[] splitUrl = ShortURL.Split('/');
            string shortenedID = splitUrl[splitUrl.Length - 1];

            try
            {
                URL url = _urlContext.UrlSet.Single(x => x.ShortenedIdentifier == shortenedID);

                //Creating the object to return to the user
                var returnObject = new
                {
                    baseUrl = _urlService.ReturnBaseUrl(_urlContext, shortenedID),
                    shortenedUrl = ShortURL,
                    useCount = _urlService.GetUrlTotalUses(_urlContext, url),
                    countries = _urlService.GetUrlCountries(_urlContext, url),
                    lastTimeAccessed = _urlService.GetLastAccessTime(_urlContext, url),
                    lastCountryAccessed = _urlService.GetLastCountryAccessed(_urlContext, url),
                };

                string returnData = JsonConvert.SerializeObject(returnObject);

                return Ok(returnData);
            }
            catch(NullReferenceException)
            {
                return StatusCode(400);
            }
        }
    }
}

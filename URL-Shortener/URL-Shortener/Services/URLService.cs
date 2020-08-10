using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using URL_Shortener.DatabaseContexts;
using URL_Shortener.Models;

namespace URL_Shortener.Services
{
    public class URLService
    {
        public IEnumerable<URL> GetAllURLs(URLContext urlContext)
        {
            return urlContext.Set<URL>();
        }

        public IEnumerable<URL> GetUserUrls(URLContext urlContext, Microsoft.AspNetCore.Http.HttpRequest request)
        {
            var userURLs = urlContext.Set<URL>();

            return userURLs;
        }
    }
}

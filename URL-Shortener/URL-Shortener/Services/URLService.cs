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

        public IEnumerable<URL> GetUserUrls(URLContext urlContext, Microsoft.AspNetCore.Http.HttpContext contextHttp)
        {
            var userURLs = urlContext.UrlSet.Where(x => x.ExternalIP == contextHttp.Connection.RemoteIpAddress.ToString()); //Ensures the same user is accessing the page by validating their IP
            userURLs = userURLs.Skip(userURLs.Count() - 5); //Gets the last 5 entries for this user

            return userURLs;
        }

        public async Task AddURL(URLContext urlContext, URL urlToAdd)
        {
            urlToAdd.ShortenedIdentifier = GenerateUrlID(urlContext, urlToAdd);

            Console.WriteLine($"Adding ID: {urlToAdd.ShortenedIdentifier} for website: {urlToAdd.BaseURL} for User (IP): {urlToAdd.ExternalIP} at {DateTime.Now}");

            await urlContext.AddAsync(urlToAdd);

            await urlContext.SaveChangesAsync();
        }

        private string GenerateUrlID(URLContext urlContext, URL url)
        {
            Console.WriteLine($"Generating ID for website: {url.BaseURL} for User (IP): {url.ExternalIP} at {DateTime.Now}");

            string id = Guid.NewGuid().ToString().Substring(0, 5);

            //Ensures that the shortened id is unique, if it has to retry 5 times, another char is allowed to be present

            int duplicateCount = 0;
            int duplicateModifier = 1;

            while(urlContext.UrlSet.Where(x => x.ShortenedIdentifier == id).Count() > 0) 
            {
                if(duplicateCount != 0 && duplicateCount % 5 == 0)
                {
                    id = Guid.NewGuid().ToString().Substring(0, 5 + duplicateModifier);
                    duplicateModifier++;
                }
                else
                {
                    id = Guid.NewGuid().ToString().Substring(0, 5);
                }

                duplicateCount++;
            }

            return id;
        }
    }
}

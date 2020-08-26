﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using URL_Shortener.Controllers;
using URL_Shortener.DatabaseContexts;
using URL_Shortener.Models;

namespace URL_Shortener.Services
{
    public class URLService
    {
        public IEnumerable<URL> GetUserUrls(URLContext urlContext, Microsoft.AspNetCore.Http.HttpContext contextHttp)
        {
            var userURLs = urlContext.UrlSet.Where(x => x.ExternalIP == contextHttp.Connection.RemoteIpAddress.ToString()); //Ensures the same user is accessing the page by validating their IP

            return userURLs;
        }

        public async Task AddURL(URLContext urlContext, URL urlToAdd)
        {
            if (urlContext.UrlSet.Where(x => x.BaseURL == urlToAdd.BaseURL).Count() == 0)
            {
                urlToAdd.ShortenedIdentifier = GenerateUrlID(urlContext, urlToAdd);

                Console.WriteLine($"Adding ID: {urlToAdd.ShortenedIdentifier} for website: {urlToAdd.BaseURL} for User (IP): {urlToAdd.ExternalIP} at {DateTime.Now}");

                await urlContext.AddAsync(urlToAdd);

                await urlContext.SaveChangesAsync();
            }
            else
            {
                urlToAdd.ShortenedIdentifier = urlContext.UrlSet.Where(x => x.BaseURL == urlToAdd.BaseURL).First().ShortenedIdentifier; //In case of a duplicate upload of a url
            }
        }

        public async Task RemoveURL(URLContext urlContext, string shortenedID)
        {
            var removeURL = urlContext.UrlSet.Single(x => x.ShortenedIdentifier == shortenedID);

            urlContext.Remove(removeURL);
            await urlContext.SaveChangesAsync();
        }

        private string GenerateUrlID(URLContext urlContext, URL url)
        {
            Console.WriteLine($"Generating ID for website: {url.BaseURL} for User (IP): {url.ExternalIP} at {DateTime.Now}");

            string id = Guid.NewGuid().ToString().Substring(0, 5);

            //Ensures that the shortened id is unique, if it has to retry 5 times, another char is allowed to be added

            int duplicateCount = 0;
            int duplicateModifier = 1;

            while (!IsIdValid(id) || urlContext.UrlSet.Where(x => x.ShortenedIdentifier == id).Count() > 0)
            {
                if (duplicateCount != 0 && duplicateCount % 5 == 0)
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

        private bool IsIdValid(string id) //Checks that the Generated ID does not have the same name as a public Action 
        {
            var temp = new URLController(this, null, null);

            foreach (var i in temp.GetType().GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public))
            {
                if(id.ToLower() == i.Name.ToLower())
                {
                    return false;
                }
            }

            return true;
        }

        public string ReturnBaseUrl(URLContext urlContext, string shortId)
        {
            try
            {
                string baseUrl = urlContext.UrlSet.Single(x => x.ShortenedIdentifier == shortId).BaseURL;
                return baseUrl;
            }
            catch(InvalidOperationException)
            {
                return "404";
            }
        }
    }
}

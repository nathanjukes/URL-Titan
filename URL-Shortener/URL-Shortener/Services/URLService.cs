using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
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
            var userURLs = urlContext.UrlUsersSet
                .Where(x => x.User.IpAddress == contextHttp.Connection.RemoteIpAddress.ToString())
                .Where(x => x.User.HasAdminPrivileges == true)
                .Select(x => x.Url); //Ensures the same user is accessing the page by validating their IP and admin privileges

            return userURLs;
        }

        public async Task AddURL(URLContext urlContext, URL urlToAdd, HttpRequest request)
        {
            if (urlContext.UrlSet.Where(x => x.BaseURL == urlToAdd.BaseURL).Count() == 0)
            {
                urlToAdd.ShortenedIdentifier = GenerateUrlID(urlContext, urlToAdd);

                Console.WriteLine($"Adding ID: {urlToAdd.ShortenedIdentifier} for website: {urlToAdd.BaseURL} for User (IP): {urlToAdd.ExternalIP} at {DateTime.Now}");

                await urlContext.UrlSet.AddAsync(urlToAdd);
                await urlContext.SaveChangesAsync();

                if(request != null)
                {
                    CreateUser(urlContext, request.HttpContext.Connection.RemoteIpAddress.ToString(), urlToAdd, true);
                }
            }
            else
            {
                urlToAdd.ShortenedIdentifier = urlContext.UrlSet.Where(x => x.BaseURL == urlToAdd.BaseURL).First().ShortenedIdentifier; //In case of a duplicate upload of a url
            }
        }

        public async Task RemoveURL(URLContext urlContext, string shortenedID)
        {
            URL removeURL = urlContext.UrlSet.Single(x => x.ShortenedIdentifier == shortenedID);

            int removeUserId = urlContext.UrlUsersSet
                .Where(x => x.UrlId == removeURL.Id)
                .Where(x => x.User.HasAdminPrivileges == true)
                .Single().UserId;

            User removeUser = urlContext.UserSet.Single(x => x.Id == removeUserId);

            urlContext.Remove(removeURL);
            urlContext.Remove(removeUser);
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

        //Returns the URL from a given short ID
        public URL ReturnUrlModel(URLContext urlContext, string shortId) => urlContext.UrlSet.Single(x => x.ShortenedIdentifier == shortId);

        public async Task UpdateUrlUsers(URLContext urlContext, HttpRequest request, URL url)
        {
            string userIpAddress = request.HttpContext.Connection.RemoteIpAddress.ToString();
            User retrievedUser;

            //Get user object for this url and this IP address - if it doesn't exist, create it
            try
            {
                retrievedUser = urlContext.UrlUsersSet.Where(x => x.UrlId == url.Id).Select(x => x.User).Where(x => x.IpAddress == request.HttpContext.Connection.RemoteIpAddress.ToString()).Single();
            }
            catch(InvalidOperationException)
            {
                User newUser = CreateUser(urlContext, userIpAddress, url, false);

                //await urlContext.UserSet.AddAsync(newUser);
                await urlContext.SaveChangesAsync();

                return;
            }

            //If retrieved user exists Update it
            retrievedUser.LastUsedTime = DateTime.Now;
            retrievedUser.UseCount += 1;

            await urlContext.SaveChangesAsync();
        }

        public int GetUrlTotalUses(URLContext urlContext, URL url)
        {
           // IEnumerable<User> urlUsers = urlContext.UserSet.Where(x => x.UrlFK == url.Id);
            IEnumerable<User> urlUsers = urlContext.UrlUsersSet.Where(x => x.UrlId == url.Id).Select(x => x.User);

            int count = 0;

            foreach(var i in urlUsers)
            {
                count += i.UseCount;
            }

            return count;
        }

        private User CreateUser(URLContext urlContext, string ipAddress, URL parentUrl, bool isAdmin)
        {
            User returnUser = new User()
            {
                IpAddress = ipAddress,
                DateInitialised = DateTime.Now,
                LastUsedTime = DateTime.Now,
                UseCount = 1,
                //UrlEntity = parentUrl,
                //UrlFK = parentUrl.Id,
                HasAdminPrivileges = isAdmin,
                CountryCode = GetCountryCode(ipAddress)
            };

            urlContext.UserSet.Add(returnUser);
            urlContext.SaveChanges();
            urlContext.UrlUsersSet.Add(new UrlUsers() { UrlId = parentUrl.Id, User = returnUser });
            urlContext.SaveChanges();
            return returnUser;
        }

        private string GetCountryCode(string ipAddress)
        {
            const string lookupApiURL = "http://ip-api.com/json/";

            WebClient wc = new WebClient();

            string jsonData = wc.DownloadString(lookupApiURL + ipAddress);

            var jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonData);

            try
            {
                if (jsonObject.status == "success")
                {
                    return jsonObject.countryCode;
                }
                else
                {
                    return "GB"; //CHANGE THIS IN OFFICIAL BUILD
                }
            }
            catch(RuntimeBinderException) //Property doesn't exist exception
            {
                return "GB"; //CHANGE THIS IN OFFICIAL BUILD
            }
        }

        public Dictionary<string, int> GetUrlCountries(URLContext urlContext, URL url)
        {
            var countryData = new Dictionary<string, int>();

            //IEnumerable<User> users = urlContext.UserSet.Where(x => x.UrlFK == url.Id);
            IEnumerable<User> users = urlContext.UrlUsersSet.Where(x => x.UrlId == url.Id).Select(x => x.User);

            foreach (var i in users)
            {
                if(!countryData.ContainsKey(i.CountryCode))
                {
                    countryData.Add(i.CountryCode, i.UseCount);
                }
                else
                {
                    countryData[i.CountryCode] += i.UseCount;
                }
            }

            return countryData;
        }

        public DateTime? GetLastAccessTime(URLContext urlContext, URL url)
        {
            //IEnumerable<User> users = urlContext.UserSet.Where(x => x.UrlFK == url.Id).OrderByDescending(x => x.LastUsedTime);
            IEnumerable<User> users = urlContext.UrlUsersSet.Where(x => x.UrlId == url.Id).Select(x => x.User).OrderByDescending(x => x.LastUsedTime);
            
            if (users != null && users.Count() != 0)
            {
                return users.First().LastUsedTime;
            }

            return null;
        }
        
        public string GetLastCountryAccessed(URLContext urlContext, URL url)
        {
            //IEnumerable<User> users = urlContext.UserSet.Where(x => x.UrlFK == url.Id).OrderByDescending(x => x.LastUsedTime);
            IEnumerable<User> users = urlContext.UrlUsersSet.Where(x => x.UrlId == url.Id).Select(x => x.User).OrderByDescending(x => x.LastUsedTime);

            if (users != null && users.Count() != 0)
            {
                return users.First().CountryCode;
            }

            return null;
        }
    }
}

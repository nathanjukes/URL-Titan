using Microsoft.AspNetCore.Http.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URL_Shortener.HelperClasses
{
    public static class URLData
    {
        public static string GetHostname(Microsoft.AspNetCore.Http.HttpRequest request)
        {
            UriBuilder uri = new UriBuilder(request.GetDisplayUrl());

            return $"https://{uri.Host}/";
        }
    }
}
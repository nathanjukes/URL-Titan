using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URL_Shortener.Models
{
    public class LinkTrackingModel
    {
        public Dictionary<string, string> UrlData { get; set; }

        public string Url { get; set; }
    }
}

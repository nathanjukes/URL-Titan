using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URL_Shortener.Models
{
    public class UrlStats 
    {
        public string baseUrl { get; set; }

        public string shortenedUrl { get; set; }

        public int useCount { get; set; }

        public Dictionary<string, int> countries { get; set; }

        public DateTime? lastTimeAccessed { get; set; }

        public string lastCountryAccessed { get; set; }
    }
}

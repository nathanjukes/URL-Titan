using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URL_Shortener.Models
{
    public class EnterURLModel
    {
        public URL UrlData { get; set; }

        public IEnumerable<URL> UserUrls { get; set; }

        public string HostName { get; set; }
    }
}

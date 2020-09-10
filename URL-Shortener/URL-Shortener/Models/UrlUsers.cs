using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace URL_Shortener.Models
{
    public class UrlUsers
    {
        public int UrlId { get; set; }
        public URL Url { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
} 

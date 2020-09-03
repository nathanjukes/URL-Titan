using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace URL_Shortener.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string IpAddress { get; set; }

        public string CountryCode { get; set; }

        public DateTime DateInitialised { get; set; } //First time accessing a link

        public DateTime LastUsedTime { get; set; } //Last time they accessed the link

        public int UseCount { get; set; }

        [ForeignKey("UrlFK")]
        public int UrlFK { get; set; }

        public URL UrlEntity { get; set; }
    }
}

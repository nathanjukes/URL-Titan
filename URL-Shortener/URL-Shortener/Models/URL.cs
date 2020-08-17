﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace URL_Shortener.Models
{
    public class URL
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Url)]
        public string BaseURL { get; set; }

        public string ShortenedIdentifier { get; set; }

        public string ExternalIP { get; set; }
    }
}

﻿
using System.ComponentModel.DataAnnotations;

namespace URL_Shortener.Models
{
    public class ContactMeModel
    {
        [Required]
        public string Name { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }
    }
}

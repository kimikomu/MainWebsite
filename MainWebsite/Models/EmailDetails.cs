using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MainWebsite.Models
{
    public class EmailDetails
    {
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a message")]
        [StringLength(500, ErrorMessage = "Message cannot be longer than 500 characters.")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        [StringLength(50, ErrorMessage = "Email cannot be longer than 50 characters.")]
        public string EmailAddress { get; set; }

        public bool Website { get; set; }

        public bool Audio { get; set; }

        public bool Programming { get; set; }
    }
}
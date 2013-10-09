using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/* User  
 * DE eigenschappen van een gebruiker van het platform.
 * */

namespace Thuiszorg.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }

        [Required]
        [StringLength(25,MinimumLength=5)]
        public string password { get; set; }

        [Required]
        public string role { get; set; }

        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string zipcode { get; set; }
        
        [Required]
        public string street { get; set; }
        
        [Required]
        public string homeNumber { get; set; }

        public string homeNumberExtra { get; set; }

        [Required]
        public string homeTelephone { get; set; }

        public string mobileTelephone { get; set; }
    }
}
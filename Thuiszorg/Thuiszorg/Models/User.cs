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
        public string password { get; set; }

        [Required]
        public string role { get; set; }

        [EmailAddress]
        public string email { get; set; }

        public string city { get; set; }

        public string zipcode { get; set; }
        
        public string street { get; set; }
        
        public string homeNumber { get; set; }

        public string homeNumberExtra { get; set; }

        public string homeTelephone { get; set; }

        public string mobileTelephone { get; set; }
    }
}
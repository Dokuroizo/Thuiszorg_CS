using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
        public string passWord { get; set; }

        public string role { get; set; }

        [EmailAddress]
        public string email { get; set; }

        public string city { get; set; }

        public string telephone { get; set; }
    }
}
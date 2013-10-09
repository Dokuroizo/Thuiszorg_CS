using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thuiszorg.Models
{
    public class User
    {
        public int ID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string passWord { get; set; }

        public string role { get; set; }

        public string email { get; set; }

        public string city { get; set; }

        public string telephone { get; set; }
    }
}
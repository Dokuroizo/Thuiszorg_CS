using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thuiszorg.Models
{
    public class Request
    {
        public int ID { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public DateTime dateAndTime { get; set; }

        public string user { get; set; }

        public bool completed { get; set; }

        
    }
}
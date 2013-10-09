using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/* Request  
 * De taken die moeten worden uitgevoerd door personen.
 * Deze taak wordt aangemaakt.
 * */

namespace Thuiszorg.Models
{
    public class Request
    {
        public int ID { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public DateTime dateAndTimeAdded { get; set; }

        public DateTime dateAndTimeRequest { get; set; }

        public string user { get; set; }

        public bool completed { get; set; }       
    }
}
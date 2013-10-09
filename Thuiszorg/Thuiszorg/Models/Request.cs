using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/* Request  
 * De taken die moeten worden uitgevoerd door personen.
 * Deze taak wordt aangemaakt.
 * Dit is de taak van een persoon en wat hij moet doen en wanneer
 * */

namespace Thuiszorg.Models
{
    public class Request
    {
        public int ID { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string description { get; set; }

        public DateTime dateAndTimeAdded { get; set; }

        [Required]
        public DateTime dateAndTimeRequest { get; set; }

        public string user { get; set; }

        public bool completed { get; set; }       
    }
}
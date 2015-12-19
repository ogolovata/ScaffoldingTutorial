using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DetailedViewAPI.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string EventIdasTitle { get; set; }
        // Foreign Key - parent pageview id
        public int PageViewId { get; set; }
        public DateTime StartDateTime { get; set; }
    }
}
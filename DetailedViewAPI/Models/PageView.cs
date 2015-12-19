using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace DetailedViewAPI.Models
{
    public class PageView
    {
        public int PageViewId { get; set; }
        [Required]

        private List<Event> _events = new List<Event>();
        public List<Event> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        public string PageViewIdasName { get; set; }
        public string pv_propertyA { get; set; }
        public string pv_propertyB { get; set; }

        public string TopicKey { get; set; }
        public string content_propertyA { get; set; }
        public string content_propertyB { get; set; }

        public string SessionId { get; set; }
        public string VisitorId { get; set; }
        public string user_propetyA { get; set; }
        public string user_propertyB { get; set; }

        public string map_propertyA { get; set; }
        public string map_propertyB { get; set; }

        public string visit_propertyA { get; set; }
        public string visit_propertyB { get; set; }

        public string issue_propertyA { get; set; }
        public string issue_propertyB { get; set; }
    }
}
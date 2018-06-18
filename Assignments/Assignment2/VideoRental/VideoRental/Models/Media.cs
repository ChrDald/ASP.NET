using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRental.Models
{
    public class Media
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public enum Type { Movie, Series, VideoGame, Hardware }
        public DateTime ProductionYear { get; set; }
       
    }
}
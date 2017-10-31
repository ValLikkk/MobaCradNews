using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobСardNews.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public News News { get; set; }
        public  ApplicationUser ApplicationUser { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int Rating { get; set; }

    }
}
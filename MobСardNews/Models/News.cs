using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobСardNews.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Tag { get;set; }
        public string Game { get; set; }
        public string Picture { get; set; }
        public List<Comment>Comments { get; set; }
        public News()
        {
            Comments = new List<Comment>();
        }
    }
}
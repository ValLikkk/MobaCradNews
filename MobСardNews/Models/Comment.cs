using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobСardNews.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public News NewsId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }
}
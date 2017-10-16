using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobСardNews.Models
{
    public class Comment
    {
        int Id { get; set; }
        News NewsId { get; set; }
        int UserId { get; set; }
        string Text { get; set; }
        DateTime Date { get; set; }
        int Likes { get; set; }
        int Dislikes { get; set; }
    }
}
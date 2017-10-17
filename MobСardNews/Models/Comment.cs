using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace MobСardNews.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public News NewsId { get; set; }
        public ApplicationUser Userid { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }
}
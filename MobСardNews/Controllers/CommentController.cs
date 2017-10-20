using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobСardNews.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace MobСardNews.Controllers
{
    public class CommentController : Controller
    {
        [HttpPost]
        public ActionResult CreateComment(Comment comment)
        {
            using (var context = new NewsDbContext())
            {
                var user = context.Profiles.FirstOrDefault(x => x.UserId == User.Identity.GetUserId());
                var addComment = new Comment { Date = DateTime.UtcNow ,NewsId = comment.NewsId,ProfileId  = user,Text = comment.Text};
            }
                return View(comment);
        }
    }
}
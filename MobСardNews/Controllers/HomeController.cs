using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobСardNews.Models;
using PagedList.Mvc;
using PagedList;
using System.Data;
using Microsoft.AspNet.Identity;
using System.Data.Entity;

namespace MobСardNews.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Вывод новостей
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public ActionResult Index(int? page, string tag)
        {
            int pageSize = 6;//Количество новостей на странице
            int pageNumber = (page ?? 1);

            var context = new ApplicationDbContext();
            var content = (context.News.ToList());
            if (tag != null)
            {
                content = context.News.Where(allNews => allNews.Game == tag).ToList();
                if (content.Count() == 0)
                    return HttpNotFound();
            }
            return View(content.ToPagedList(pageNumber, pageSize));
        }           

            //using (context = new ApplicationDbContext())
            //{
            //    //context.Database.ExecuteSqlCommand("TRUNCATE TABLE [NEWS]");
            //    //context.Database.ExecuteSqlCommand("TRUNCATE TABLE [Comments]");
            //    //for (int i = 0; i < 2; i++)
            //    //{
            //    //    context.News.Add(new News
            //    //    {
            //    //        Game = "HearStone",
            //    //        Text = "не думай" + i
            //    //    });
            //    //    context.News.Add(new News { Game = "Artifact", Text = "где game габен" + i });
            //    //    context.News.Add(new News { Game = "Dota2", Text = "где патч габен" + i });
            //    //    context.News.Add(new News { Game = "Gwent", Text = "быстро надоедает" + i });
            //    //}

            //    //context.SaveChanges();
            //    return View((context.News.ToList()).ToPagedList(pageNumber, pageSize));
                //using (var context = new ApplicationDbContext())
                //{

                //    context.News.Add(new News { Game = "Dota" });
                //    context.SaveChanges();
                //}
        public virtual ActionResult NewsBlock(int? id)
        {
            using (var context = new ApplicationDbContext())
            {
                News model = context.News.Include(x => x.Comments.Select(p =>p.ApplicationUser)).FirstOrDefault(news => news.Id == id);
                return View(model);
            }

        }

        [HttpPost]
        public virtual ActionResult AddComment(string comment,int id)
        {
            using (var context = new ApplicationDbContext())
            {
                News model = context.News.FirstOrDefault(news => news.Id == id);
                DbAddComment(comment, id);
                return RedirectToAction("NewsBlock", "Home", model);
            }
            //return PartialView("NewsBlock");
        }

        private void DbAddComment(string comment, int newsId)
        {
            using (var context = new ApplicationDbContext())
            {
                var currentNews = context.News.FirstOrDefault(x => x.Id == newsId);
                var getUser = User.Identity.GetUserId();
                var currentUser = context.Users.FirstOrDefault(x =>x.Id == getUser);
                var addComment = new Comment() { Date = DateTime.UtcNow, Text = comment,News = currentNews,ApplicationUser = currentUser};
                context.Comments.Add(addComment);
                context.SaveChanges();
            }
        }
    }
}
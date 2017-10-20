using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobСardNews.Models;
using PagedList.Mvc;
using PagedList;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

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

            var context = new NewsDb();
            var content = (context.News.ToList());
            //if (User.Identity.IsAuthenticated)
            //{
            //    var Profile = new Profile { FirstName = "Федор" };
            //    context.Profiles.Add(Profile);
            //    context.SaveChanges();
            //    var news = context.News.FirstOrDefault(x => x.Id == 1);
            //    var comment = new Comment() { Date = DateTime.UtcNow, NewsId = news, Text = "Фёдор", ProfileId = Profile };
            //    context.Comments.Add(comment);
            //    context.SaveChanges();
            //}
            if (tag != null)
            {
                content = context.News.Where(allNews => allNews.Game == tag).ToList();
                if (content.Count() == 0)
                    return HttpNotFound();
            }
            return View(content.ToPagedList(pageNumber, pageSize));
            //using (context = new ApplicationDbContext())
            //{
            //    //context.Database.ExecuteSqlCommand("TRUNCATE TABLE [NEWS]");
            //    for (int i = 0; i < 2; i++)
            //    {
            //        context.News.Add(new News { Game = "HearStone", Text = "не думай" + i });
            //        context.News.Add(new News { Game = "Dota2", Text = "где патч габен" + i });
            //        context.News.Add(new News { Game = "Artifact", Text = "где патч габен" + i });
            //        context.News.Add(new News { Game = "Gwent", Text = "где патч габен" + i });
            //    }
            //    context.SaveChanges();
            //    return View((context.News.ToList()).ToPagedList(pageNumber, pageSize));
            //}

            //using (var context = new ApplicationDbContext())
            //{

            //    context.News.Add(new News { Game = "Dota" });
            //    context.SaveChanges();
            //}
        }

        public virtual ActionResult NewsBlock(int? id)
        {
            using (var context = new NewsDb())
            {
                News model = context.News.FirstOrDefault(news => news.Id == id);
                return View(model);
            }

        }

        //[HttpGet]
        //public ActionResult SearchByTag(string tag)
        //{
        //    using (var context = new ApplicationDbContext())
        //    {
        //        var newsByTag = context.News.Where(allNews => allNews.Game == tag).ToList();
        //        if (newsByTag.Count() == 0)
        //            return HttpNotFound();
        //        return PartialView(newsByTag);
        //    }
        //}
    }
}
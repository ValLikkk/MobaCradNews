using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobСardNews.Models;
using PagedList.Mvc;
using PagedList;

namespace MobСardNews.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Вывод новостей
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public ActionResult Index(int? page)
        {
            int pageSize = 6;//Количество новостей на странице
            int pageNumber = (page ?? 1);
            var context = new ApplicationDbContext();
            return View((context.News.ToList()).ToPagedList(pageNumber, pageSize));
            //using (var context = new ApplicationDbContext())
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        context.News.Add(new News { Id = i, Game = "Dota" + i });
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
    }
}
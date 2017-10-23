using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobСardNews.Models.RestModels
{
    public class AddComment
    {
        public string Text { get; set; }
        public int NewsId { get; set; }
    }
}
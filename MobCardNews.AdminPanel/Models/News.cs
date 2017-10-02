using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobCardNews.AdminPanel.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string tag { get; set; }
        public string Game { get; set; }
    }
}
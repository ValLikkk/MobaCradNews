using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MobСardNews.Models
{
    public class Profile 
    {   
        public int Id { get; set; }
        public string UserId { get; set; } // external key to AspNetUser
        public virtual  AspNetUser AspNetUser  { get; set; }
        public List<Comment> Comments { get; set; }
        public long? AvatarId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }  
    }
}
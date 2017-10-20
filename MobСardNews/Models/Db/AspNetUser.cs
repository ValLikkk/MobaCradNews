using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MobСardNews.Models
{
    public class AspNetUser : IdentityUser
    {
        public AspNetUser()
        {
            AutoLoginKey = Guid.NewGuid().ToString().ToLower().Replace("-", "");
        }

        public string AutoLoginKey { get; set; }

        public DateTime? LastPasswordChanged { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime Created { get; set; }

        /// <summary>
        /// Пользователь с ошибкой авторизации и не обновлённым паролем
        /// </summary>
        public bool IsAuthProblemAndNotUpdatedPsw { get; set; }

    }
}
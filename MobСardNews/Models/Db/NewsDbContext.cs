using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using MobСardNews.Models.Db.Mappings.Applicant;

namespace MobСardNews.Models.Db
{
    public class NewsDbContext : ApplicationDbContext
    {
        public NewsDbContext(string connectionString) 
            : base(connectionString)
        {
        }

        public NewsDbContext()
            : this("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<News> News { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ApplicantNewsConfiguration());
            modelBuilder.Configurations.Add(new ApplicantCommentConfiguration());
            modelBuilder.Configurations.Add(new ApplicantProfileConfiguration());
            modelBuilder.Configurations.Add(new ApplicantAspNetUserConfigurations());
        }
       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace MobСardNews.Models.Db.Mappings.Applicant
{
    public class ApplicantAspNetUserConfigurations : EntityTypeConfiguration<AspNetUser>
    {
        public ApplicantAspNetUserConfigurations()
        {
            HasKey(x => x.Id);
        }
    }
}
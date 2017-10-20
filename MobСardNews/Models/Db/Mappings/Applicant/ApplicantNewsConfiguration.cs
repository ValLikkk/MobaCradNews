using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace MobСardNews.Models.Db.Mappings.Applicant
{
    public class ApplicantNewsConfiguration : EntityTypeConfiguration<News>
    {
        public ApplicantNewsConfiguration()
        {
            HasKey(x => x.Id);
        }
    }
}
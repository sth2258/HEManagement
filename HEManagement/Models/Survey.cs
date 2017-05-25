using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HEManagement.Models
{
    public class Survey
    {
        public Guid SurveyID { get; set; }

        [Display(Name ="Survey Taken")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString =
      "{0:yyyy-MM-dd}",
       ApplyFormatInEditMode = true)]
        public DateTime SurveyDateTime { get;set;}

        public Guid CustomerID { get; set; }

        public int CeilingHeight { get; set; }

        public virtual ICollection<SurveyItemExisting> SurveyItems { get; set; }


    }

    public class SurveyDBContext : DbContext
    {
        public DbSet<Survey> SurveyItemExisting { get; set; }
    }

}
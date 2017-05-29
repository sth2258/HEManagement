using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Display(Name ="Customer")]
        public Guid CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
        [Display(Name ="Ceiling Height"), Range(1,10000)]
        public int CeilingHeight { get; set; }

    }

    public class SurveyDBContext : DbContext
    {
        public DbSet<Survey> Survey { get; set; }
    }

}
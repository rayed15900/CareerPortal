using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.EF.Models
{
    public class Job_Applicant
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Job")]
        public int JobId { get; set; }
        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; }
    }
}
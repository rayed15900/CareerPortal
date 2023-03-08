using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.EF.Models
{
    public class Applicant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ApplicationSatus { get; set; }
        [Required]
        public DateTime ApplyDate { get; set; } = DateTime.Now;

        [Required]
        [ForeignKey("Job")]
        public int JobId { get; set; }
        [Required]
        [ForeignKey("UserProfile")]
        public int UserProfileId { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.EF.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Salary { get; set; }
        [Required]
        public string ExperienceLevel { get; set; }
        [Required]
        public string EducationLevel { get; set; }
        [Required]
        public string EmploymentType { get; set; }
        [Required]
        public string[] Skills { get; set; }
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Required]
        public DateTime ExpireDate { get; set; }
        [Required]
        [ForeignKey("Employer")]
        public int EmployerId { get; set;}
        [Required]
        [ForeignKey("Company")]
        public string CompanyId { get; set; }
    }
}
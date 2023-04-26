using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class EmployerJobPosts
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Title { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }
        [Required]
        [StringLength(20)]
        public string Type { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        [StringLength(20)]
        public string Location { get; set; }
        [Required]
        [StringLength(200)]
        public string RequiredSkills { get; set; }
        [Required]
        [StringLength(200)]
        public string EducationLevel { get; set; }
        [Required]
        [StringLength(20)]
        public string Experience { get; set; }
        [Required]
        public DateTime ApplicationDeadline { get; set; }
        [Required]
        [StringLength(20)]
        public string CompanyName { get; set; }
        [Required]
        [EmailAddress]
        public string CompanyMail { get; set; }

        [Required]
        [ForeignKey("empProfile")]
        public string Employer_Id { get; set; }
        public virtual EmployerProfile empProfile { get; set; }

        [Required]
        [ForeignKey("Categories")]
        public string Category_Id { get; set; }

        public virtual ManageCategory Categories { get; set; }

        public virtual ICollection<AppliedJob> AppliedJobs { get; set; }
        public EmployerJobPosts()
        {
            AppliedJobs = new List<AppliedJob>();
        }
    }
}

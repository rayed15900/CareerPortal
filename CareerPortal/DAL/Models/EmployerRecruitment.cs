using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class EmployerRecruitment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool Shortlist { get; set; }

        [ForeignKey("empProfile")]
        public string Employer_Id { get; set; }
        public virtual EmployerProfile empProfile { get; set; }

        [ForeignKey("appProfile")]
        public string Applicant_Id { get; set; }
        public virtual ApplicantProfile appProfile { get; set; }

        [ForeignKey("empJobPosts")]
        public string JobPost_Id { get; set; }
        public virtual EmployerJobPosts empJobPosts { get; set; }
    }
}

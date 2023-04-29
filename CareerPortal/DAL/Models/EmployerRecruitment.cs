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
        public int Employer_Id { get; set; }
        public virtual EmployerProfile empProfile { get; set; }

        [ForeignKey("appProfile")]
        public int Applicant_Id { get; set; }
        public virtual ApplicantProfile appProfile { get; set; }

<<<<<<< HEAD
        [ForeignKey("empJobPosts")]
        public string JobPost_Id { get; set; }
        public virtual EmployerJobPosts empJobPosts { get; set; }
=======
        [ForeignKey("empJobPost")]
        public int JobPost_Id { get; set; }
        public virtual EmployerJobPost empJobPost { get; set; }
>>>>>>> fa832b9aa173802a0df0fabd61c032030c8d9690
    }
}

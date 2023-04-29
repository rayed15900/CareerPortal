using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ApplicantJobApply
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; }
        [Required]
        public string PositionName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string ExpectedSalary { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        public virtual ApplicantProfile Applicant {  get; set; }
        public virtual ICollection<AppliedJob> AppliedJobs { get; set; }
        public ApplicantJobApply() 
        {
            AppliedJobs = new List<AppliedJob>();
        }
    }
}

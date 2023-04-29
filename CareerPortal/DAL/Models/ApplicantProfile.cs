using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ApplicantProfile
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(30)]
        public string Mail { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string Address { get; set; }
        [StringLength(100)]
        public string About { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<ApplicantEducationalQualification> Qualifications { get; set; }
        public ApplicantProfile()
        {
            Qualifications=new List<ApplicantEducationalQualification>();
        }
    }
}

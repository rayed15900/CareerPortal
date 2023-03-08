using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.EF.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string[] Skills { get; set; }
        [Required]
        public byte[] Resume { get; set; }
        [Required]
        public string ExperienceLevel { get; set; }
        [Required]
        public string EducationLevel { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
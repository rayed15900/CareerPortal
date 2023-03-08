using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.EF.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; }
        [Required]
        [ForeignKey("Employer")]
        public int EmployerId { get; set; }
        [Required]
        public string MessageContent { get; set; }
        [Required]
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.EF.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Company")]
        public string CompanyId { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
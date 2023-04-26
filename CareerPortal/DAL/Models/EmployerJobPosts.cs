﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [StringLength(20)]
        public string Category { get; set; }
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobPortal.EF.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set;}
        [Required]
        public string Email { get; set;}
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set;}
        [Required]
        public string Phone { get; set; }
        [Required]
        public DateTime DOB { get; set;}
    }
}
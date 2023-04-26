using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{

    public class ManageUsers
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UId { get; set; }
        public virtual ICollection<User> Users { get; set;}
        public ManageUsers()
        {
            Users = new List<User>();
        }
    }
}

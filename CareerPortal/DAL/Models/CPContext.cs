using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CPContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ApplicantProfile> ApplicantProfiles { get; set; }
        public DbSet<AdminProfile> AdminProfiles { get; set; }
<<<<<<< HEAD
        public DbSet<ApplicantManageResume> applicantManageResumes { get; set; }
        public DbSet<AdminProfile> lol { get; set; }

=======
        
<<<<<<< HEAD
        public DbSet<ApplicantManageResume> ApplicantManageResumes { get; set; }
=======
        public DbSet<ApplicantManageResume> applicantManageResumes { get; set; }

        public DbSet<AdminProfile> lol { get; set; }
>>>>>>> 6668b02ead7165c0bf33b12793ca9c95ab1ba3e4
>>>>>>> 18adf6ec0826154e1ac61a68d6cfb721b8aeb5c6
    }
}

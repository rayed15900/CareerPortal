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
<<<<<<< HEAD
        public DbSet<ApplicantJobApply> ApplicantJobApply { get; set; }
        public DbSet<ApplicantEducationalQualification> Qualifications { get; set; }

=======
        public DbSet<EmployerJobPost> EmployerJobPosts { get; set; }
        public DbSet<EmployerProfile> EmployerProfiles { get; set; }
        public DbSet<EmployerRecruitment> EmployerRecruitments { get; set; }
>>>>>>> fa832b9aa173802a0df0fabd61c032030c8d9690
    }
}

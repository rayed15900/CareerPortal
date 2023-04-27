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
        public DbSet<EmployerJobPosts> EmployerJobPosts { get; set; }
        public DbSet<EmployerProfile> EmployerProfiles { get; set; }
        public DbSet<EmployerRecruitment> EmployerRecruitments { get; set; }
    }
}

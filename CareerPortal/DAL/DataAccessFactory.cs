using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, int, bool> UserData()
        {
            return new UserRepo();
        }
        public static IRepo<EmployerJobPost, int, bool> EmployerJobPostData()
        {
            return new EmployerJobPostRepo();
        }
        public static IRepo<EmployerProfile, int, bool> EmployerProfileData()
        {
            return new EmployerProfileRepo();
        }
        public static IRepo<EmployerRecruitment, int, bool> EmployerRecruitmentData()
        {
            return new EmployerRecruitmentRepo();
        }
    }
}

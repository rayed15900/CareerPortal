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
<<<<<<< HEAD
        public static IRepo<ApplicantProfile,int,bool> ApplicantData()
        {
            return new ApplicantProfileRepo();
        }
        public static IRepo<ApplicantEducationalQualification,int,bool> ApplicantEducationalData()
        {
            return new ApplicantEducationRepo();
        }
        public static IRepo<ApplicantJobApply, int, bool> ApplicantJobApplyData()
        {
            return new ApplicantJobApplyRepo();
=======
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
>>>>>>> fa832b9aa173802a0df0fabd61c032030c8d9690
        }
    }
}

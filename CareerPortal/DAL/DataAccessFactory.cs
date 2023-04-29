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

        public static IRepo<ManageUsers, int, bool> ManagerUserData()
        {
            return new ManageUserRepo();
        }
        public static IRepo<ManageJobPost, int, bool> ManageJobPostData()
        {
            return new ManageJobPostRepo();
        }
        public static IRepo<ManageCategory, int, bool> ManageCategoryData()
        {
            return new ManageCategoryRepo();
        }

        public static IRepo<User, int, bool> UserData()
=======
        public static IRepo<ApplicantProfile,int,bool> ApplicantData()
>>>>>>> b3a796ff2906d560b556748561c276478e7e11a2
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
        }
    }
}

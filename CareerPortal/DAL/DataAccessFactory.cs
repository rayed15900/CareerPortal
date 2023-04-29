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
        }
    }
}

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
    }
}

using BLL.DTOs;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminProfileService
    {
        public static List<AdminProfileDTO> Get()
        {
            var data = DataAccessFactory.AdminData().Get();
            return Convert(data);
        }

        static AdminProfileDTO Convert(AdminProfile adminProfile)
        {
            return new AdminProfileDTO()
            {
                Id = adminProfile.Id,
                Name = adminProfile.Name,
                username = adminProfile.username,
                password = adminProfile.password
            };
        }

        static AdminProfile Convert(AdminProfileDTO admin)
        {
            return new AdminProfile()
            {
                Id = admin.Id,
                Name = admin.Name,
                username = admin.username,
                password = admin.password
            };
        }
    }
}

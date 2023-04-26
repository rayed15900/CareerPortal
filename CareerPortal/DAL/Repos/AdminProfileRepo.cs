using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminProfileRepo : Repo, IRepo<AdminProfile, int, bool>
    {
        public bool Delete(int id)
        {
            var adpro = Get(id);
            db.AdminProfiles.Remove(adpro);
            return db.SaveChanges() > 0;
        }

        public List<AdminProfile> Get()
        {
            return db.AdminProfiles.ToList();
        }

        public AdminProfile Get(int id)
        {
            return db.AdminProfiles.Find(id);
        }

        public bool Insert(AdminProfile obj)
        {
            db.AdminProfiles.Add(obj);
            return db.SaveChanges()>0;
        }

        public bool Update(AdminProfile obj)
        {
            var adminProfils = Get(obj.Id);
            db.Entry(adminProfils).CurrentValues.SetValues(obj);
            return db.SaveChanges()>0;
        }
    }
}

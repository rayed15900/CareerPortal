using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
<<<<<<< HEAD:CareerPortal/DAL/Models/Categories.cs
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
=======
    public interface IRepo<Type,ID,RET>
    {
        RET Create(Type obj);
        List<Type> Read();
        Type Read(ID iD);
        RET Update(Type obj);
        bool Delete(ID iD);
>>>>>>> 2de6877469fc150d8e43b29b72f70d5279f3da5f:CareerPortal/DAL/Interfaces/IRepo.cs
    }
}

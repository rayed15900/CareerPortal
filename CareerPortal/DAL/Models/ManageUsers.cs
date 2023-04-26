using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
<<<<<<< HEAD:CareerPortal/DAL/Models/ManageUsers.cs
    public class ManageUsers
    {

=======
    public interface IRepo<Type,ID,RET>
    {
        RET Create(Type obj);
        List<Type> Read();
        Type Read(ID id);
        RET Update(Type obj);
        bool Delete(ID id);
>>>>>>> 18adf6ec0826154e1ac61a68d6cfb721b8aeb5c6:CareerPortal/DAL/Interfaces/IRepo.cs
    }
}

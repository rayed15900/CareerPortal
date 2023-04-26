using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<Type,ID,RET>
    {
        RET Create(Type obj);
        List<Type> Read();
        Type Read(ID iD);
        RET Update(Type obj);
        bool Delete(ID iD);
    }
}

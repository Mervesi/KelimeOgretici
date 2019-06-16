using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IAccessRepo<T>
    {
        int Create(T arg);
        int Update(T arg);
        void Delete(int arg);
        List<T> GetAll();
    }
}

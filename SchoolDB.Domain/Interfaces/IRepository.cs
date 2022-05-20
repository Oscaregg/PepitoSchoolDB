using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB.Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Create(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetAll();
    }
}

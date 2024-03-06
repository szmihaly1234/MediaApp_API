using MediaApp_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        IQueryable<T> ReadAll();
        T Read(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}

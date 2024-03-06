using MediaApp_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IStudioLogic
    {
        void Create(Studio studio);
        void Delete(int id);
        Studio Read(int id);
        IEnumerable<Studio> ReadAll();
        void Update(Studio studio);
    }
}

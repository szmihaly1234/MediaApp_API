using Data.Interfaces;
using Logic.Interfaces;
using MediaApp_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services
{
    public class StudioLogic : IStudioLogic
    {
        IStudioRepository studioRepo;
        public StudioLogic(IStudioRepository studioRepo)
        {
            this.studioRepo = studioRepo;
        }

        public void Create(Studio studio)
        {
            studioRepo.Create(studio);
        }

        public void Delete(int id)
        {
            studioRepo.Delete(id);
        }

        public Studio Read(int id)
        {
            Studio studio = studioRepo.Read(id);
            if(studio == null)
            {
                throw new ArgumentException("Invalid ID");
            }
            return studio;
        }

        public IEnumerable<Studio> ReadAll()
        {
            return studioRepo.ReadAll();
        }

        public void Update(Studio studio)
        {
            studioRepo.Update(studio);
        }
    }
}

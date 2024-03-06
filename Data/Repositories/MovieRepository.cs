﻿using Data.Interfaces;
using MediaApp_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class MovieRepository : Repository<Movie>,IMovieRepository
    {
        public MovieRepository(MediaAppDbContext dbContext) : base(dbContext) { }
        public override void Update(Movie item)
        {
            var old = Read(item.Id);
            foreach (var prop in old.GetType().GetProperties())
            {
                if (prop.GetAccessors().FirstOrDefault(t => t.IsVirtual) == null)
                {
                    prop.SetValue(old, prop.GetValue(item));
                }
            }
            ctx.SaveChanges();
        }
    }
}

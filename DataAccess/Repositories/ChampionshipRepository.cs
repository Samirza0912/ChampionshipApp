using System;
using System.Collections.Generic;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class ChampionshipRepository:IRepository<Championship>
    {
        public bool Create(Championship entity)
        {
           DataContext.Championships.Add(entity);
           return true;
        }

        public bool Delete(Championship entity)
        {
            DataContext.Championships.Remove(entity);
            return true;
        }

        public List<Championship> GetAll(Predicate<Championship> filter = null)
        {
            return filter == null ? DataContext.Championships :
                DataContext.Championships.FindAll(filter);
        }

        public Championship GetOne(Predicate<Championship> filter = null)
        {
            return filter == null ? DataContext.Championships[0] :
                DataContext.Championships.Find(filter);
        }

        public bool Update(Championship entity)
        {
            Championship isExist = GetOne(s => s.Id == entity.Id);
            isExist = entity;
            return true;
        }
    }
}

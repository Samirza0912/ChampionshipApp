using System;
using System.Collections.Generic;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repositories
{
    public class TeamRepository: IRepository<Team>
    {
        public bool Create(Team entity)
        {
            DataContext.Teams.Add(entity);
            return true;
        }
        public bool Delete(Team entity)
        {
            DataContext.Teams.Remove(entity);
            return true;
        }
        public List<Team> GetAll(Predicate<Team> filter=null)
        {
            return filter == null ? DataContext.Teams :
             DataContext.Teams.FindAll(filter);
        }
        public Team GetOne(Predicate<Team> filter = null)
        {
            return filter == null ? DataContext.Teams[0] :
                DataContext.Teams.Find(filter);
        }
        public bool Update(Team entity)
        {
            Team isExist = GetOne(s => s.Id == entity.Id);
            isExist = entity;
            return true;
        }
    }
}

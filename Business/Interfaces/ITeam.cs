using System;
using System.Collections.Generic;
using Entities.Models;

namespace Business.Interfaces
{
    public interface ITeam
    {
        Team Create(Team team);
        Team Update(int Id, Team team);
        Team Delete(int Id);
        Team GetTeam(string name);
        Team GetTeam(int id);
        List<Team> GetAll(string name = null);
    }
}

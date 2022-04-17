using System;
using System.Collections.Generic;
using DataAccess.Repositories;
using Entities.Models;

namespace Business.Services
{
    public class TeamService
    {
        public static int Count { get; set; }
        private TeamRepository _teamRepository;
        public TeamService()
        {
            _teamRepository = new TeamRepository();
        }
        public Team Create(Team team)
        {
            team.Id = Count;

            _teamRepository.Create(team);
            Count++;
            return team;
        }
        public Team Delete(int Id)
        {
            Team isExist = _teamRepository.GetOne(g => g.Id == Id);
            if (isExist == null)
            {
                return null;
            }
            _teamRepository.Delete(isExist);
            return isExist;
        }

        public Team GetTeam(string name)
        {
            return _teamRepository.GetOne(g => g.Name == name);
        }

        public Team Update(int Id, Team team)
        {
            return _teamRepository.GetOne();
        }

        public List<Team> GetAll()
        {
            return _teamRepository.GetAll();
        }

        public Team GetTeam(int id)
        {
            return _teamRepository.GetOne(g => g.Id == id);
        }

        public List<Team> GetAll(string name = null)
        {
            throw new NotImplementedException();
        }
    }
}

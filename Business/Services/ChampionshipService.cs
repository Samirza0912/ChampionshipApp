using System;
using System.Collections.Generic;
using Business.Interfaces;
using DataAccess;
using DataAccess.Repositories;
using Entities.Models;

namespace Business.Services
{
    public class ChampionshipService: IChampionship
    {
        public static int Count { get; set; }
        private ChampionshipRepository _championshipRepository;
        public ChampionshipService()
        {
            _championshipRepository = new ChampionshipRepository();
        }
        public Championship Create(Championship championship)
        {
            championship.Id = Count;

            _championshipRepository.Create(championship);
            Count++;
            return championship;
        }
        public Championship Delete(int Id)
        {
            Championship isExist = _championshipRepository.GetOne(g => g.Id == Id);
            if (isExist == null)
            {
                return null;
            }
            _championshipRepository.Delete(isExist);
            return isExist;
        }
        public Championship GetChampionship(string name)
        {
            return _championshipRepository.GetOne(g => g.Name == name);
        }
        public List<Championship> GetAll()
        {
            return _championshipRepository.GetAll();
        }
        public Championship GetChampionship(int id)
        {
            return _championshipRepository.GetOne(g => g.Id == id);
        }
        public Championship Update(int id, Championship championship)
        {
            Championship isExsit = _championshipRepository.GetOne(g => g.Id == id);
            if (isExsit == null)
            {
                return null;
            }
            isExsit.Name = championship.Name;
            _championshipRepository.Update(championship);
            return championship;
        }
        public List<Championship> GetAll(string name = null)
        {
            throw new NotImplementedException();
        }
    }
}

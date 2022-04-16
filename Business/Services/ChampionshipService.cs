using System;
using System.Collections.Generic;
using Business.Interfaces;
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

        public Championship Update(int Id, Championship championship)
        {
            return _championshipRepository.GetOne();
        }

        public List<Championship> GetAll()
        {
            return _championshipRepository.GetAll();
        }

        public Championship GetChampionship(int id)
        {
            return _championshipRepository.GetOne(g => g.Id == id);
        }

        public List<Championship> GetAll(string name = null)
        {
            throw new NotImplementedException();
        }
    }
}

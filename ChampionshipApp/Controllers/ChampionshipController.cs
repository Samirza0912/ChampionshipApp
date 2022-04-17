using Business.Services;
using DataAccess;
using Entities.Models;
using System;
using Utilities.Helper;
namespace ChampionshipApp.Controllers
{
    public class ChampionshipController
    {
        private ChampionshipService championshipService;
        public ChampionshipController()
        {
            championshipService = new ChampionshipService();
        }
        public void CreateChampionship()
        {
        EnterName:
            Extension.Print(ConsoleColor.Green, $"Championship Name");
            string ChampionshipName = Console.ReadLine();
            Extension.Print(ConsoleColor.Green, $"Championship Size");
            string ChampionshipSize = Console.ReadLine();
            int size;
            bool isSize = int.TryParse(ChampionshipSize, out size);
            if (isSize)
            {
                Championship championship = new Championship
                {
                    Name = ChampionshipName,
                    MaxSize = size
                };

                championshipService.Create(championship);
                Extension.Print(ConsoleColor.Green, $"{championship.Name} created");
            }
            else
            {
                Extension.Print(ConsoleColor.Red, "Please enter correctly");
                goto EnterName;
            }
        }
        public void GetAllChampionships()
        {
            foreach (var item in championshipService.GetAll())
            {
                Extension.Print(ConsoleColor.Yellow, $"{item.Name}");
            }
        }
        public void RemoveChampionship()
        {
            int id = int.Parse(Console.ReadLine());
            Extension.Print(ConsoleColor.Green, $"{championshipService.Delete(id).Name}");
        }
        public void UpdateChampionship()
        {
            updateChampionship:
            Extension.Print(ConsoleColor.Green, "Enter ID: ");
            int id;
            bool isExist = int.TryParse(Console.ReadLine(), out id);
            Extension.Print(ConsoleColor.Green, "Enter new Championship's Name: ");
            string name = Console.ReadLine();
            if (isExist)
            {
                Championship championship = new Championship
                {
                    Name = name
                };
                Extension.Print(ConsoleColor.Green, $"New championship's name: {championshipService.Update(id, championship).Name}");
            }
            else
            {
                Extension.Print(ConsoleColor.Red, "Please enter correctly");
                goto updateChampionship;
            }
        }
    }
}

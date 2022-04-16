using System;
using Business.Services;
using Entities.Models;
using Utilities.Helper;

namespace ChampionshipApp.Controllers
{
    public class TeamsController
    {
        private TeamsService _teamsService;
        public TeamsController()
        {
            _teamsService = new TeamsController();
        }
        public void AddTeam()
        {
            Extension.Print(ConsoleColor.Green, "Enter Team's Name: ");
            string name = Console.ReadLine();
            Team team = new Team
            {
                Name = name,
            };
            _teamsService.Create(team);
            Extension.Print(ConsoleColor.Green, $"Team {team.Name} has been added ");
        }
        public void UpdateTeam()
        {
            updateTeam:
            Extension.Print(ConsoleColor.Green, "Enter Team's ID: ");
            int id;
            bool IsExist = int.TryParse(Console.ReadLine(), out id);
            Extension.Print(ConsoleColor.Green, "Enter Team's Name: ");
            string name = Console.ReadLine();
            if (IsExist)
            {
                Team team = new Team
                {
                    Name = name,
                };
                _teamsService.Update(id, team);
                Extension.Print(ConsoleColor.Green, $"The Team Has Been Updated");
            }
            else
            {
                Extension.Print(ConsoleColor.Red, "Please Enter Correctly");
                goto updateTeam;
            }
        }
        public void RemoveTeam()
        {
            removeTeam:
            Extension.Print(ConsoleColor.Green, "Enter Team's ID: ");
            int id;
            bool IsExist = int.TryParse(Console.ReadLine(), out id);
            if (IsExist)
            {
                Extension.Print(ConsoleColor.Green, $"{_teamsService.Delete(id).Name}");
            }
            else
            {
                Extension.Print(ConsoleColor.Red, "Please Enter Correctly");
                goto removeTeam;
            }
        }
        public void GetTeam()
        {
            Extension.Print(ConsoleColor.Green, "Enter Team's ID: ");
            int id = int.Parse(Console.ReadLine());
            Extension.Print(ConsoleColor.Green, $"{_teamsService.GetGuest(id).Name}");
        }
        public void GetAllTeams()
        {
            foreach (var item in _teamsService.GetAll())
            {
                Extension.Print(ConsoleColor.Yellow, $"ID: {item.Id}; Name: {item.Name}");
            }
        }
    }
}

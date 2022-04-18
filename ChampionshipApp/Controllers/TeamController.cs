using System;
using Business.Services;
using Entities.Models;
using Utilities.Helper;

namespace ChampionshipApp.Controllers
{
    public class TeamController
    {
        private TeamService teamService;
        public TeamController()
        {
            teamService = new TeamService();
        }
        public void CreateTeam()
        {
        EnterName:
            Extension.Print(ConsoleColor.Green, "Team Name");
            string TeamName = Console.ReadLine();
            if (TeamName.Length<=20 && TeamName.Length>0)
            {
                Team team = new Team
                {
                    Name = TeamName,
                    
                };
                teamService.Create(team);
                Extension.Print(ConsoleColor.Green, $"{team.Name} created");
            }
            else
            {
                Extension.Print(ConsoleColor.Red, "Team's name should be between 0 and 20 symbols");
                goto EnterName;
            }
        }
        public void GetAllTeams()
        {
            foreach (var item in teamService.GetAll())
            {
                Extension.Print(ConsoleColor.Yellow, $"{item.Name}");
            }
        }
        public void RemoveTeam()
        {
            int id = int.Parse(Console.ReadLine());
            Extension.Print(ConsoleColor.Green, $"{teamService.Delete(id).Name}");
        }
        public void Update()
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
                teamService.Update(id, team);
                Extension.Print(ConsoleColor.Green, $"The Team has been Updated");
            }
            else
            {
                Extension.Print(ConsoleColor.Red, "Please write correctly");
                goto updateTeam;
            }
        }
    }
}

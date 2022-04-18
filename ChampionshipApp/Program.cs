using System;
using ChampionshipApp.Controllers;
using Entities.Models;
using Utilities.Helper;

namespace ChampionshipApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Extension.Print(ConsoleColor.Green, "Welcome to our Committie");
            while (true)
            {
                ChampionshipController championshipService = new ChampionshipController();
                TeamController teamController = new TeamController();
                Extension.Print(ConsoleColor.Magenta, "1-Create Championship\n" +
                    "2-Update Championship\n" +
                    "3-Remove Championship by ID\n" +
                    "4-GetAll Championships\n" +
                    "5-Add Team\n" +
                    "6-Update Team\n" +
                    "7-Remove Team by ID\n" +
                    "8-GetAll Teams");
                string num = Console.ReadLine();
                int input;
                bool IsNum = int.TryParse(num, out input);
                if (IsNum && input < 9 && input > 0)
                {
                    switch (input)
                    {
                        
                        case (int)Extension.MenuForChampionship.CreateChampionship: Console.Clear();
                            championshipService.CreateChampionship();
                            break;
                        case (int)Extension.MenuForChampionship.UpdateChampionship:
                            championshipService.Update();
                            break;
                        case (int)Extension.MenuForChampionship.RemoveChampionship:
                            championshipService.RemoveChampionship();
                            break;
                        case (int)Extension.MenuForChampionship.GetAllChampionships:
                            championshipService.GetAllChampionships();
                            break;
                        case (int)Extension.MenuForTeam.AddTeam:
                            teamController.CreateTeam();
                            break;
                        case (int)Extension.MenuForTeam.UpdateTeam:
                            teamController.Update();
                            break;
                        case (int)Extension.MenuForTeam.RemoveTeam:
                            teamController.RemoveTeam();
                            break;
                        case (int)Extension.MenuForTeam.GetAllTeams:
                            teamController.GetAllTeams();
                            break;
                    }
                }
            }
        }
    }
}

using System;
using ChampionshipApp.Controllers;
using Utilities.Helper;

namespace ChampionshipApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Extension.Print(ConsoleColor.Green, "Welcome to our commitet");
            while (true)
            {
                ChampionshipController championshipController = new ChampionshipController();
                Extension.Print(ConsoleColor.Cyan, "1-Create Championship\n" +
                    "2-Update Championship\n" +
                    "3-Remove Championship\n" +
                    "4-Get Championship\n" +
                    "5-GetAll Championship");
                string num = Console.ReadLine();
                int input;
                bool IsNum = int.TryParse(num, out input);
                if (IsNum && input < 6 && input > 0)
                {
                    switch (input)
                    {
                        case (int)Extension.MenuForChampionship.CreateChampionship:
                            championshipController.CreateChampionship();
                            break;
                        case (int)Extension.MenuForChampionship.UpdateChampionship:
                            break;
                        case (int)Extension.MenuForChampionship.RemoveChampionship:
                            championshipController.RemoveChampionship();
                            break;
                        case (int)Extension.MenuForChampionship.GetChampionship:
                            break;
                        case (int)Extension.MenuForChampionship.GetAllChampionships:
                            championshipController.GetAllChampionships();
                            break;
                    }
                }
            }
        }
    }
}

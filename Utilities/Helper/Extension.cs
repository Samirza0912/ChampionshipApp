using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Helper
{
    public class Extension
    {
        public static void Print(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public enum MenuForChampionship
        {
            CreateChampionship=1, UpdateChampionship, RemoveChampionship,GetAllChampionships
        }
        public enum MenuForTeam
        {
            AddTeam = 5, UpdateTeam, RemoveTeam,GetAllTeams
        }
    }
}

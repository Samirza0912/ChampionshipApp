using System;
namespace Utilities
{
    public class Extension
    {
        public static void Print(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public enum Menu
        {

        }
    }
}

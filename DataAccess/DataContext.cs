using System;
using System.Collections.Generic;
using Entities.Models;


namespace DataAccess
{
    public class DataContext 
    {
        public static List<Championship> Championships { get; set; }
        public static List<Team> Teams { get; set; }
        static DataContext()
        {
            Teams = new List<Team>();
            Championships = new List<Championship>();
        }
    }
}

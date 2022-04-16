using System;
using Entities.Interfaces;
using System.Collections.Generic;
using System.Text;


namespace Entities.Models
{
    public class Team:IEntity 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

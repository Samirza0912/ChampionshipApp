using System;
using Entities.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Championship:IEntity 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxSize { get; set; }
    }
}

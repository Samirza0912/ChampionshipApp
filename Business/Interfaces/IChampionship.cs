using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;


namespace Business.Interfaces
{
    public class IChampionship 
    {
        Championship Create(Championship championship);
        Championship Update(int Id, Championship championship);
        Championship Delete(int Id);
        Championship GetChampionship(string name);
        Championship GetChampionship(int id);
        List<Championship> GetAll(string name = null);
    }
}

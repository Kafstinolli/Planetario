using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Models.ViajesEspaciales
{
    public class Objetivo
    {
        public int Id { get; set; }
        public string Name { get;set; }

        public Objetivo(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

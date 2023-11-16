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
        public string Nombre { get;set; }

        public Objetivo(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}

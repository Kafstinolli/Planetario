using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPlanetario.Models.MPlanetario
{
    public class PlanetarioC
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public PlanetarioC(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}

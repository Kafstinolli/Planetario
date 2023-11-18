using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Models.ViajesEspaciales
{
    public class Astronauta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdProfesion { get; set; }

        public Astronauta(int id, string nombre, int idProfesion) 
        {
            Id = id;
            Nombre = nombre;
            IdProfesion = idProfesion;
        }
    }
}

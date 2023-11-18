using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPlanetario.Models.MPlanetario
{
    public class Satelite
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Excentricidad { get; set; }
        public double PeriodoOrbital { get; set; }
        public double InclinacionOrbital { get; set; }

        public Satelite(int id, string nombre, double excentricidad, double periodoOrbital, double inclinacionOrbital)
        {
            Id = id;
            Nombre = nombre;
            Excentricidad = excentricidad;
            PeriodoOrbital = periodoOrbital;
            InclinacionOrbital = inclinacionOrbital;
        }
    }
}

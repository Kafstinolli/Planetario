using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Models.Planetario
{
    public class PlanetarioPlaneta
    {
        public int Id { get; set; }
        public int PlanetarioId {  get; set; }
        public int PlanetaId { get; set; }

        public PlanetarioPlaneta(int id, int planetarioId, int planetaId) 
        {
            Id = id;
            PlanetarioId = planetarioId;
            PlanetaId = planetaId;
        }
    }
}

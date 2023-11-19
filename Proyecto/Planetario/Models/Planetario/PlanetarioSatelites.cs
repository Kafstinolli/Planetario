using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Models.Planetario
{
    public class PlanetarioSatelites
    {
        public int Id { get; set; }
        public int PlanetarioId { get; set; }
        public int SateliteId { get; set; }

        public PlanetarioSatelites(int id, int planetarioId, int sateliteId)
        {
            Id = id;
            PlanetarioId = planetarioId;
            SateliteId = sateliteId;
        }
    }
}

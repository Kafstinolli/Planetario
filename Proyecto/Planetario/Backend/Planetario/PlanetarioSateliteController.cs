using NPlanetario.Data.DPlanetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Backend.Planetario
{
    public class PlanetarioSateliteController
    {
        public void Add(PlanetarioServer planetarioServer, string query)
        {
            planetarioServer.CreatePlanetarioSatelites(query);
        }

        public void Remove(PlanetarioServer planetarioServer, string query, int id)
        {
            query += $" WHERE PlanetarioSatelites_Id = {id}";

            planetarioServer.DeletePlanetarioSatelites(query);
        }
    }
}

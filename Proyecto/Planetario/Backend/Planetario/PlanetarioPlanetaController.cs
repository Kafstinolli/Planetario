using NPlanetario.Data.DPlanetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Backend.Planetario
{
    public class PlanetarioPlanetaController
    {
        public void Add(PlanetarioServer planetarioServer, string query)
        {
            planetarioServer.CreatePlanetarioPlanetas(query);
        }

        public void Remove(PlanetarioServer planetarioServer, string query, int id)
        {
            query += $" WHERE PlanetarioPlanetas_Id = {id}";

            planetarioServer.DeletePlanetarioPlanetas(query);
        }
    }
}

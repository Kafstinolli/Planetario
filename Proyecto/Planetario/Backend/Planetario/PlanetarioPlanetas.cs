using NPlanetario.Data.DPlanetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Backend.Planetario
{
    public class PlanetarioPlanetas
    {
        public void Add(PlanetarioServer planetarioServer, string query)
        {
            Console.Clear();

            planetarioServer.CreatePlanetarioPlanetas(query);

            Console.WriteLine("Se creó el planetario correctamente");
        }

        public void Remove(PlanetarioServer planetarioServer, string query, int id)
        {
            Console.Clear();

            query += $" WHERE PlanetarioPlanetas_Id = {id}";

            planetarioServer.DeletePlanetarioPlanetas(query);

            Console.WriteLine("Se eliminó el planetario correctamente");
        }
    }

}
}

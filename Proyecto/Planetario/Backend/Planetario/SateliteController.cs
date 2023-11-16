using Planetario.Data.Planetario;
using Planetario.Models.Planetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Backend.Planetario
{
    public class SateliteController
    {
        public void Add(PlanetarioServer planetarioServer, string query)
        {
            Console.Clear();

            planetarioServer.CreateSatelite(query);

            Console.WriteLine("Se creó el satelite correctamente");
        }

        public void Show(PlanetarioServer planetarioServer, string query)
        {
            Console.Clear();

            List<Satelite> satelites = planetarioServer.ReadSatelites(query);

            foreach (Satelite satelite in satelites)
            {
                Console.WriteLine($"| {satelite.Nombre} | {satelite.Excentricidad} | {satelite.PeriodoOrbital} | {satelite.InclinacionOrbital} |");
            }
        }

        public void Edit(PlanetarioServer planetarioServer, string query, int id)
        {
            Console.Clear();

            query += $" WHERE Satelite_Id = {id}";

            planetarioServer.UpdateSatelite(query);

            Console.WriteLine("Se editó el satelite correctamente");
        }

        public void Remove(PlanetarioServer planetarioServer, string query, int id)
        {
            Console.Clear();

            query += $" WHERE Satelite_Id = {id}";

            planetarioServer.DeleteSatelite(query);

            Console.WriteLine("Se eliminó el Satelite correctamente");
        }
    }
}

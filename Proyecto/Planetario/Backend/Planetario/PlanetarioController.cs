using NPlanetario.Data.DPlanetario;
using NPlanetario.Models.MPlanetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPlanetario.Backend.BPlanetario
{
    public class PlanetarioController
    {
        public void Add(PlanetarioServer planetarioServer, string query)
        {
            Console.Clear();

            planetarioServer.CreatePlanetario(query);

            Console.WriteLine("Se creó el planetario correctamente");
        }

        public void Show(PlanetarioServer planetarioServer, string query)
        {
            Console.Clear();

            List<PlanetarioC> planetarios = planetarioServer.ReadPlanetarios(query);

            foreach (PlanetarioC planetario in planetarios)
            {
                Console.WriteLine($"| {planetario.Id} | {planetario.Nombre} |");
            }
        }

        public void Edit(PlanetarioServer planetarioServer, string query, int id)
        {
            Console.Clear();

            query += $" WHERE Planetario_Id = {id}";

            planetarioServer.UpdatePlanetario(query);

            Console.WriteLine("Se editó el planetario correctamente");
        }

        public void Remove(PlanetarioServer planetarioServer, string query, int id)
        {
            Console.Clear();

            query += $" WHERE Planetario_Id = {id}";

            planetarioServer.DeletePlanetario(query);

            Console.WriteLine("Se eliminó el planetario correctamente");
        }
    }

}

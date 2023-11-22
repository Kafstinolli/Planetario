using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Planetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Relaciones.Planetario
{
    public class PlanetarioSatelite
    {
        public static void MostrarMenu()
        {
            Console.Clear();

            LoadBalancer loadBalancer = new LoadBalancer();

            MostrarPlanetarios.Mostrar();

            Console.WriteLine("Digite el ID del planetario al que se le asignará un satelite:");
            int idPlanetario = Convert.ToInt32(Console.ReadLine());

            MostrarSatelites.Mostrar();

            Console.WriteLine("Digite el ID del satelite que será asignado al planetario");
            int idSatelite = Convert.ToInt32(Console.ReadLine());

            Request request = new Request($"INSERT INTO PlanetarioSatelites (PlanetarioSatelites_PlanetarioId, PlanetarioSatelites_SateliteId) VALUES ({idPlanetario}, {idSatelite})", "planetario", "planetarioSatelite");

            loadBalancer.INSERT(request);
        }
    }
}

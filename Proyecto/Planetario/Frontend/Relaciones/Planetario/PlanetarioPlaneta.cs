using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Planetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Relaciones.Planetario
{
    public class PlanetarioPlaneta
    {
        public static void MostrarMenu()
        {
            Console.Clear();

            LoadBalancer loadBalancer = new LoadBalancer();

            MostrarPlanetarios.Mostrar();

            Console.WriteLine("Digite el ID del planetario al que se le asignará un planeta:");
            int idPlanetario = Convert.ToInt32(Console.ReadLine());

            MostrarPlanetas.Mostrar();

            Console.WriteLine("Digite el ID del planeta que será asignado al planetario");
            int idPlaneta = Convert.ToInt32(Console.ReadLine());

            Request request = new Request($"INSERT INTO PlanetarioPlanetas (PlanetarioPlanetas_PlanetarioId, PlanetarioPlanetas_PlanetaId) VALUES ({idPlanetario}, {idPlaneta})", "planetario", "planetarioPlanetas");

            loadBalancer.INSERT(request);
        }
    }
}

using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Planetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Eliminar.Planetario
{
    public class EliminarPlanetario
    {
        public static void Eliminar()
        {
            LoadBalancer _loadBalanecer = new LoadBalancer();

            int idPlanetario;

            Console.WriteLine("\n");

            MostrarPlanetarios.Mostrar();

            Console.WriteLine("\nDigite el ID del planetario a eliminar:");

            idPlanetario = Convert.ToInt32(Console.ReadLine());

            Request request = new Request("DELETE FROM Planetario", "planetario", "planetario");

            _loadBalanecer.DELETE(request, idPlanetario);
        }
    }
}

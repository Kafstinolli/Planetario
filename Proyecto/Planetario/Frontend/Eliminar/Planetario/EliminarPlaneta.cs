using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Planetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Eliminar.Planetario
{
    public class EliminarPlaneta
    {
        public static void Eliminar()
        {
            LoadBalancer _loadBalanecer = new LoadBalancer();

            int idPlaneta;

            Console.WriteLine("\n");

            MostrarPlanetas.Mostrar();

            Console.WriteLine("\nDigite el ID del planeta a eliminar:");

            idPlaneta = Convert.ToInt32(Console.ReadLine());

            Request request = new Request("DELETE FROM Planeta", "planetario", "planeta");

            _loadBalanecer.DELETE(request, idPlaneta);
        }
    }
}

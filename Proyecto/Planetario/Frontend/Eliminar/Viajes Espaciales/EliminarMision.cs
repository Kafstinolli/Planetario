using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Planetario;
using Planetario.Frontend.Mostrar.Viajes_Espaciales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Eliminar.Viajes_Espaciales
{
    public class EliminarMision
    {
        public static void Eliminar()
        {
            LoadBalancer _loadBalanecer = new LoadBalancer();

            int idMision;

            Console.WriteLine("\n");

            MostrarMisiones.Mostrar();

            Console.WriteLine("\nDigite el ID del planetario a eliminar:");

            idMision = Convert.ToInt32(Console.ReadLine());

            Request request = new Request("DELETE FROM Mision", "viajesEspaciales", "mision");

            _loadBalanecer.DELETE(request, idMision);
        }
    }
}

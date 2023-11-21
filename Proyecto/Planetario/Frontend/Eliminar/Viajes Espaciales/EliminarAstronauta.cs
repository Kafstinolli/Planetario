using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Viajes_Espaciales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Eliminar.Viajes_Espaciales
{
    public class EliminarAstronauta
    {
        public static void Eliminar()
        {
            LoadBalancer _loadBalanecer = new LoadBalancer();

            int idAstronauta;

            Console.WriteLine("\n");

            MostrarAstronautas.Mostrar();

            Console.WriteLine("\nDigite el ID del planetario a eliminar:");

            idAstronauta = Convert.ToInt32(Console.ReadLine());

            Request request = new Request("DELETE FROM Astronauta", "viajesEspaciales", "astronauta");

            _loadBalanecer.DELETE(request, idAstronauta);
        }
    }
}

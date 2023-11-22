using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Viajes_Espaciales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Eliminar.Viajes_Espaciales
{
    public class EliminarProfesion
    {
        public static void Eliminar()
        {
            LoadBalancer _loadBalanecer = new LoadBalancer();

            int idProfesion;

            Console.WriteLine("\n");

            MostrarProfesion.Mostrar();

            Console.WriteLine("\nDigite el ID de la profesion a eliminar:");

            idProfesion = Convert.ToInt32(Console.ReadLine());

            Request request = new Request("DELETE FROM Profesion", "viajesEspaciales", "profesion");

            _loadBalanecer.DELETE(request, idProfesion);
        }
    }
}

using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Planetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Eliminar.Planetario
{
    internal class EliminarSatelite
    {
        public static void Eliminar()
        {
            LoadBalancer _loadBalanecer = new LoadBalancer();

            int idSatelite;

            Console.WriteLine("\n");

            MostrarSatelites.Mostrar();

            Console.WriteLine("\nDigite el ID del satelite a eliminar:");

            idSatelite = Convert.ToInt32(Console.ReadLine());

            Request request = new Request("DELETE FROM Satelite", "planetario", "satelite");

            _loadBalanecer.DELETE(request, idSatelite);
        }
    }
}

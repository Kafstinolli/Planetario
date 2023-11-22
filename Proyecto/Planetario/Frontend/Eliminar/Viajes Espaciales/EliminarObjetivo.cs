using NPlanetario.LoadBalancing;
using Planetario.Frontend.Mostrar.Viajes_Espaciales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Eliminar.Viajes_Espaciales
{
    public class EliminarObjetivo
    {
        public static void Eliminar()
        {
            LoadBalancer _loadBalanecer = new LoadBalancer();

            int idObjetivo;

            Console.WriteLine("\n");

            MostrarObjetivos.Mostrar();

            Console.WriteLine("\nDigite el ID del objetivo a eliminar:");

            idObjetivo = Convert.ToInt32(Console.ReadLine());

            Request request = new Request("DELETE FROM Objetivo", "viajesEspaciales", "objetivo");

            _loadBalanecer.DELETE(request, idObjetivo);
        }
    }
}

using NPlanetario.LoadBalancing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Crear.Planetario
{
    public class CrearPlanetario
    {
        public static void Crear()
        {
            LoadBalancer loadBalancer = new LoadBalancer();

            string nombrePlanetario;

            Console.WriteLine("Introduzca el nombre del planetario");
            nombrePlanetario = Console.ReadLine();

            Request request = new Request($"INSERT INTO Planetario (Planetario_Nombre) VALUES ('{nombrePlanetario}')", "planetario", "planetario");
            loadBalancer.INSERT(request);
        }
    }
}

using NPlanetario.LoadBalancing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Crear.Viajes_Espaciales
{
    public class CrearProfesion
    {
        public static void Crear()
        {
            LoadBalancer loadBalancer = new LoadBalancer();

            string nombreProfesion;

            Console.WriteLine("Digite el nombre del objetivo:");
            nombreProfesion = Console.ReadLine();

            Request request = new Request($"INSERT INTO Profesion (Profesion_Nombre) VALUES ('{nombreProfesion}')", "viajesEspaciales", "profesion");
            loadBalancer.INSERT(request);
        }
    }
}

using NPlanetario.LoadBalancing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Crear.Viajes_Espaciales
{
    public class CrearAstronauta
    {
        public static void Crear()
        {
            LoadBalancer loadBalancer = new LoadBalancer();

            string nombreAstronauta;
            int profesionId;

            Console.WriteLine("Digite el nombre del astronauta:");
            nombreAstronauta = Console.ReadLine();

            Console.WriteLine("Digite el ID de la profesion del astronauta: ");
            profesionId = Convert.ToInt32(Console.ReadLine());

            Request request = new Request($"INSERT INTO Astronauta (Astronauta_Nombre, Astronauta_ProfesionId) VALUES ('{nombreAstronauta}', {profesionId})", "viajesEspaciales", "astronauta");
            loadBalancer.INSERT(request);
        }
    }
}

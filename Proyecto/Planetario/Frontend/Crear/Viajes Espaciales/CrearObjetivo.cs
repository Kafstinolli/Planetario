using NPlanetario.LoadBalancing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Crear.Viajes_Espaciales
{
    public class CrearObjetivo
    {
        public static void Crear()
        {
            LoadBalancer loadBalancer = new LoadBalancer();

            string nombreObjetivo;

            Console.WriteLine("Digite el nombre del objetivo:");
            nombreObjetivo = Console.ReadLine();

            Request request = new Request($"INSERT INTO Objetivo (Objetivo_Nombre) VALUES ('{nombreObjetivo}')", "viajesEspaciales", "objetivo");
            loadBalancer.INSERT(request);
        }
    }
}

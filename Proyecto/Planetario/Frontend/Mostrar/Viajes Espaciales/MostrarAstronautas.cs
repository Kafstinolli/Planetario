using NPlanetario.LoadBalancing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Mostrar.Viajes_Espaciales
{
    internal class MostrarAstronautas
    {
        public static void Mostrar()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            Request request = new Request("SELECT Astronauta_Id, Astronauta_Nombre, Astronauta_ProfesionId FROM Astronauta", "viajesEspaciales", "astronauta");

            _loadBalancer.SELECT(request);
        }
    }
}

using NPlanetario.LoadBalancing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Mostrar.Viajes_Espaciales
{
    public class MostrarProfesion
    {
        public static void Mostrar()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            Request request = new Request("SELECT Profesion_Id, Profesion_Nombre FROM Profesion", "viajesEspaciales", "profesion");

            _loadBalancer.SELECT(request);
        }
    }
}

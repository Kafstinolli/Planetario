using NPlanetario.LoadBalancing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Mostrar.Viajes_Espaciales
{
    internal class MostrarMisiones
    {
        public static void Mostrar()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            Request request = new Request("SELECT Mision_Id, Mision_Nombre, Mision_Fecha, Mision_AstronautaId, Mision_ObjetivoId FROM Mision", "viajesEspaciales", "mision");
            
            _loadBalancer.SELECT(request);
        }

    }
}

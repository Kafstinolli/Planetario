using NPlanetario.LoadBalancing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Mostrar.Planetario
{
    public class MostrarSatelites
    {
        public static void Mostrar()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            Request request = new Request("SELECT Satelite_Id, Satelite_Nombre, Satelite_Excentricidad, Satelite_PeriodoOrbital, Satelite_InclinacionOrbital FROM Satelite", "planetario", "satelite");
            _loadBalancer.SELECT(request);
        }
    }
}

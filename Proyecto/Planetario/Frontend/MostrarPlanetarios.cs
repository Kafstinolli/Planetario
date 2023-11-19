using NPlanetario.LoadBalancing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend
{
    public class MostrarPlanetarios
    {
        public static void Mostrar()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();
            
            Request request = new Request("SELECT  Planetario_Id, Planetario_Nombre FROM Planetario", "planetario", "planetario");
            _loadBalancer.SELECT(request);
        }
    }
}

using NPlanetario.LoadBalancing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Mostrar.Viajes_Espaciales
{
    internal class MostrarObjetivos
    {
        public static void Mostrar()
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            Request request = new Request("SELECT Objetivo_Id, Objetivo_Nombre FROM Objetivo", "viajesEspaciales", "objetivo");

            _loadBalancer.SELECT(request);
        }

    }
}

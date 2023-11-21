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
        public static void Crear(string nombrePlanetario)
        {
            LoadBalancer _loadBalancer = new LoadBalancer();

            Request request = new Request($"INSERT INTO Planetario (Planetario_Nombre) VALUES ({nombrePlanetario})", "planetario", "planetario");
            _loadBalancer.INSERT(request);
        }
    }
}

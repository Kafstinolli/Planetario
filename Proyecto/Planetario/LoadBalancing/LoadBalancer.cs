using System.Data.Common;
using Planetario.Backend;
using Planetario.Data;

namespace Planetario.LoadBalancing;

public class LoadBalancer
{
    private PlanetarioController _planetarioController = new PlanetarioController();
    public void prueba(Request request)
    {
        if (request.Id == "planetario")
        {
            //  Conexión Santiago:
            //  PlanetarioServer planetarioServer = new PlanetarioServer("softiRedsLaptop", "sa", "isabella12"); 

            //  Conexión Mateo:
            PlanetarioServer planetarioServer = new PlanetarioServer("DESKTOP-RGNT8FG\\SQLEXPRESS", "sa", "Project1");

            //  Conexión Juanes:

            //  Conexión Ximena:

            //  Conexión Andrés:

            _planetarioController.Show(planetarioServer, request.Nombre);
        }
    }
}
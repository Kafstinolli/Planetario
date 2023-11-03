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
            //  PlanetarioServer planetarioServer = new PlanetarioServer("DESKTOP-RGNT8FG\\SQLEXPRESS", "sa", "Project1");

            //  Conexión Juanes:
            PlanetarioServer planetarioServer = new PlanetarioServer("JUANES", "sa", "juanes211520");

            //  Conexión Ximena:
            //  PlanetarioServer planetarioServer = new PlanetarioServer("LAPTOP-0G61ILIU\\SQLEXPRESS", "sa", "sql123");
            // :( 

            //  Conexión Andrés:
            //  PlanetarioServer planetarioServer = new PlanetarioServer("ANDRES\\SQLEXPRESS", "sa", "Kilian16");

            _planetarioController.Show(planetarioServer, request.Nombre);
        }
    }
}
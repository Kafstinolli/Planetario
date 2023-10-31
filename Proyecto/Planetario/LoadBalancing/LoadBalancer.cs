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
            //  Conexi�n Santiago:
            //  PlanetarioServer planetarioServer = new PlanetarioServer("softiRedsLaptop", "sa", "isabella12"); 

            //  Conexi�n Mateo:
            PlanetarioServer planetarioServer = new PlanetarioServer("DESKTOP-RGNT8FG\\SQLEXPRESS", "sa", "Project1");

            //  Conexi�n Juanes:

            //  Conexi�n Ximena:

            //  Conexi�n Andr�s:

            _planetarioController.Show(planetarioServer, request.Nombre);
        }
    }
}
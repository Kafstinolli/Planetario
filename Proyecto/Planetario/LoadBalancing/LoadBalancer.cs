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
            PlanetarioServer planetarioServer = new PlanetarioServer("softiRedsLaptop", "sa", "isabella12");
            _planetarioController.Show(planetarioServer, request.Nombre);
        }
    }
}
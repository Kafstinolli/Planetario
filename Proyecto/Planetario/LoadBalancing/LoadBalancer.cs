using System.Data.Common;
using Planetario.Backend.Planetario;
using Planetario.Backend.ViajesEspaciales;
using Planetario.Data;
using Planetario.Data.Planetario;
using Planetario.Data.ViajesEspaciales;

namespace Planetario.LoadBalancing;

public class LoadBalancer
{
    private PlanetarioController _planetarioController = new PlanetarioController();
    private ViajesEspacialesController _viajesEspacialesController = new ViajesEspacialesController();

    private PlanetarioServer _planetarioServer;
    private ViajesEspacialesServer _viajesEspacialesServer;

    public void SELECT(Request request)
    {
        //  Conexi�n Santiago:
        //   _planetarioServer = new PlanetarioServer("softiRedsLaptop", "sa", "isabella12");
        //   _viajesEspacialesServer = new ViajesEspacialesServer("softiRedsLaptop", "sa", "isabella12"); 

        //  Conexi�n Mateo:
        //   _planetarioServer = new PlanetarioServer("DESKTOP-RGNT8FG\\SQLEXPRESS", "sa", "Project1");
        //   _viajesEspacialesServer = new ViajesEspacialesServer("DESKTOP-RGNT8FG\\SQLEXPRESS", "sa", "Project1");

        //  Conexi�n Juanes:
        //   _planetarioServer = new PlanetarioServer("JUANES", "sa", "juanes211520");
        //   _viajesEspacialesServer = new ViajesEspacialesServer("JUANES", "sa", "juanes211520");

        //  Conexi�n Ximena:
        //   _planetarioServer = new PlanetarioServer("LAPTOP-0G61ILIU\\SQLEXPRESS", "sa", "sql123");
        //   _viajesEspacialesServer = new ViajesEspacialesServer("LAPTOP-0G61ILIU\\SQLEXPRESS", "sa", "sql123");
        // :( 

        //  Conexi�n Andr�s:
        //   _planetarioServer = new PlanetarioServer("ANDRES\\SQLEXPRESS", "sa", "Kilian16");
        //   _viajesEspacialesServer = new ViajesEspacialesServer("ANDRES\\SQLEXPRESS", "sa", "Kilian16");

        if (request.Id == "planetario")
        {
            _planetarioController.Show(_planetarioServer, request.Query);
        }
        else if (request.Id == "viajesEspaciales")
        {
            _viajesEspacialesController.Show(_viajesEspacialesServer, request.Query);
        }
    }

    public void INSERT(Request request)
    {
        //  Conexi�n Santiago:
        //   _planetarioServer = new PlanetarioServer("softiRedsLaptop", "sa", "isabella12");
        //   _viajesEspacialesServer = new ViajesEspacialesServer("softiRedsLaptop", "sa", "isabella12"); 

        //  Conexi�n Mateo:
        //   _planetarioServer = new PlanetarioServer("DESKTOP-RGNT8FG\\SQLEXPRESS", "sa", "Project1");
        //  _viajesEspacialesServer = new ViajesEspacialesServer("DESKTOP-RGNT8FG\\SQLEXPRESS", "sa", "Project1");

        //  Conexi�n Juanes:
        //   _planetarioServer = new PlanetarioServer("JUANES", "sa", "juanes211520");
        //   _viajesEspacialesServer = new ViajesEspacialesServer("JUANES", "sa", "juanes211520");

        //  Conexi�n Ximena:
        //   _planetarioServer = new PlanetarioServer("LAPTOP-0G61ILIU\\SQLEXPRESS", "sa", "sql123");
        //   _viajesEspacialesServer = new ViajesEspacialesServer("LAPTOP-0G61ILIU\\SQLEXPRESS", "sa", "sql123");
        // :( 

        //  Conexi�n Andr�s:
        //   _planetarioServer = new PlanetarioServer("ANDRES\\SQLEXPRESS", "sa", "Kilian16");
        //   _viajesEspacialesServer = new ViajesEspacialesServer("ANDRES\\SQLEXPRESS", "sa", "Kilian16");

        if (request.Id == "planetario")
        {
            _planetarioController.Add(_planetarioServer, request.Query);
        }
        else if (request.Id == "viajesEspaciales")
        {
            _viajesEspacialesController.Add(_viajesEspacialesServer, request.Query);
        }
    }
}
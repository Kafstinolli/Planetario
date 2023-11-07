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
    
    public void prueba(Request request)
    {
        if (request.Id == "planetario")
        {
            //  Conexi�n Santiago:
            //  PlanetarioServer planetarioServer = new PlanetarioServer("softiRedsLaptop", "sa", "isabella12"); 

            //  Conexi�n Mateo:
            //  PlanetarioServer planetarioServer = new PlanetarioServer("DESKTOP-RGNT8FG\\SQLEXPRESS", "sa", "Project1");

            //  Conexi�n Juanes:
            //  PlanetarioServer planetarioServer = new PlanetarioServer("JUANES", "sa", "juanes211520");

            //  Conexi�n Ximena:
            //  PlanetarioServer planetarioServer = new PlanetarioServer("LAPTOP-0G61ILIU\\SQLEXPRESS", "sa", "sql123");
            // :( 

            //  Conexi�n Andr�s:
            //  PlanetarioServer planetarioServer = new PlanetarioServer("ANDRES\\SQLEXPRESS", "sa", "Kilian16");

            //  _planetarioController.Show(planetarioServer, request.Query);
        }
        else if(request.Id == "viajesEspaciales")
        {
            //  Conexi�n Santiago:
            //  ViajesEspacialesServer viajesEspacialesServer = new ViajesEspacialesServer("softiRedsLaptop", "sa", "isabella12"); 

            //  Conexi�n Mateo:
            //  ViajesEspacialesServer viajesEspacialesServer = new ViajesEspacialesServer("DESKTOP-RGNT8FG\\SQLEXPRESS", "sa", "Project1");

            //  Conexi�n Juanes:
            //  ViajesEspacialesServer viajesEspacialesServer = new ViajesEspacialesServer("JUANES", "sa", "juanes211520");

            //  Conexi�n Ximena:
            //  ViajesEspacialesServer viajesEspacialesServer = new ViajesEspacialesServer("LAPTOP-0G61ILIU\\SQLEXPRESS", "sa", "sql123");
            // :( 

            //  Conexi�n Andr�s:
            //  ViajesEspacialesServer viajesEspacialesServer = new ViajesEspacialesServer("ANDRES\\SQLEXPRESS", "sa", "Kilian16");

            //  _viajesEspacialesController.Show(viajesEspacialesServer, request.Query);
        }
    }
}
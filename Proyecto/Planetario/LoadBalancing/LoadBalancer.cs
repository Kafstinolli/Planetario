using System.Data.Common;
using NPlanetario.Backend.BPlanetario;
using NPlanetario.Backend.ViajesEspaciales;
using NPlanetario.Data;
using NPlanetario.Data.DPlanetario;
using NPlanetario.Data.ViajesEspaciales;

namespace NPlanetario.LoadBalancing;

public class LoadBalancer
{
    private PlanetaController _planetarioController = new PlanetaController();
    private SateliteController _sateliteController = new SateliteController();

    private MisionController _viajesEspacialesController = new MisionController();
    private ObjetivoControler _objetivoController = new ObjetivoControler();
    private ProfesionController _profesionController = new ProfesionController();
    private AstronataController _astronataController = new AstronataController();

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
            switch (request.Model)
            {
                case "planeta":
                    _planetarioController.Show(_planetarioServer, request.Query);
                    break;
                case "satelite":
                    _sateliteController.Show(_planetarioServer, request.Query);
                    break;
            }
        }
        else if (request.Id == "viajesEspaciales")
        {
            switch (request.Model)
            {
                case "mision":
                    _viajesEspacialesController.Show(_viajesEspacialesServer, request.Query);
                    break;
                case "objetivo":
                    _objetivoController.Show(_viajesEspacialesServer, request.Query);
                    break;
                case "profesion":
                    _profesionController.Show(_viajesEspacialesServer, request.Query);
                    break;
                case "astronauta":
                    _astronataController.Show(_viajesEspacialesServer, request.Query);
                    break;
            }
        }
    }

    public void INSERT(Request request)
    {
        //  Conexi�n Santiago:
        //   _planetarioServer = new PlanetarioServer("softiRedsLaptop", "sa", "isabella12");
        //   _viajesEspacialesServer = new ViajesEspacialesServer("softiRedsLaptop", "sa", "isabella12"); 

        //  Conexi�n Mateo:
        //  _planetarioServer = new PlanetarioServer("DESKTOP-RGNT8FG\\SQLEXPRESS", "sa", "Project1");
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
            switch (request.Model)
            {
                case "planeta":
                    _planetarioController.Add(_planetarioServer, request.Query);
                    break;
                case "satelite":
                    _sateliteController.Add(_planetarioServer, request.Query);
                    break;
            }
            
        }
        else if (request.Id == "viajesEspaciales")
        {
            switch (request.Model)
            {
                case "misión":
                    _viajesEspacialesController.Add(_viajesEspacialesServer, request.Query);
                    break;
                case "objetivo":
                    _objetivoController.Add(_viajesEspacialesServer, request.Query);
                    break;
                case "profesion":
                    _profesionController.Add(_viajesEspacialesServer, request.Query);
                    break;
                case "astronauta":
                    _astronataController.Add(_viajesEspacialesServer, request.Query);
                    break;
            }
        }
    }

    public void UPDATE(Request request, int id)
    {
        //  Conexi�n Santiago:
        //  _planetarioServer = new PlanetarioServer("softiRedsLaptop", "sa", "isabella12");
        //  _viajesEspacialesServer = new ViajesEspacialesServer("softiRedsLaptop", "sa", "isabella12"); 

        //  Conexi�n Mateo:
        //  _planetarioServer = new PlanetarioServer("DESKTOP-RGNT8FG\\SQLEXPRESS", "sa", "Project1");
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
            switch (request.Model)
            {
                case "planeta":
                    _planetarioController.Edit(_planetarioServer, request.Query, id);
                    break;
                case "satelite":
                    _sateliteController.Edit(_planetarioServer, request.Query, id);
                    break;
            }
        }
        else if (request.Id == "viajesEspaciales")
        {
            switch (request.Model)
            {
                case "mision":
                    _viajesEspacialesController.Edit(_viajesEspacialesServer, request.Query, id);
                    break;
                case "objetivo":
                    _objetivoController.Edit(_viajesEspacialesServer, request.Query, id);
                    break;
                case "profesion":
                    _profesionController.Edit(_viajesEspacialesServer, request.Query, id);
                    break;
                case "astronauta":
                    _astronataController.Edit(_viajesEspacialesServer, request.Query, id);
                    break;
            }
        }
    }

    public void DELETE(Request request, int id)
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
        //   :( 

        //  Conexi�n Andr�s:
        //   _planetarioServer = new PlanetarioServer("ANDRES\\SQLEXPRESS", "sa", "Kilian16");
        //   _viajesEspacialesServer = new ViajesEspacialesServer("ANDRES\\SQLEXPRESS", "sa", "Kilian16");

        if (request.Id == "planetario")
        {
            switch (request.Model)
            {
                case "planeta":
                    _planetarioController.Remove(_planetarioServer, request.Query, id);
                    break;
                case "satelite":
                    _sateliteController.Remove(_planetarioServer, request.Query, id);
                    break;
            }
        }
        else if (request.Id == "viajesEspaciales")
        {
            switch (request.Model)
            {
                case "mision":
                    _viajesEspacialesController.Remove(_viajesEspacialesServer, request.Query, id);
                    break;
                case "objetivo":
                    _objetivoController.Remove(_viajesEspacialesServer, request.Query, id);
                    break;
                case "profesion":
                    _profesionController.Remove(_viajesEspacialesServer, request.Query, id);
                    break;
                case "astronauta":
                    _astronataController.Remove(_viajesEspacialesServer, request.Query, id);
                    break;
            }
        }
    }
}
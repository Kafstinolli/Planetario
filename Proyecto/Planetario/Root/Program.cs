using NPlanetario.Data;
using NPlanetario.LoadBalancing;
using NPlanetario.Frontend;

internal class Program
{
    private static void Main(string[] args)
    {
        LoadBalancer loadBalancer = new LoadBalancer();
        //  Request request = new Request("SELECT  Planetario_Id, Planetario_Nombre FROM Planetario", "planetario", "planetario");

        //  Request request = new Request("SELECT Astronauta_Id, Astronauta_Nombre, Astronauta_ProfesionId FROM Astronauta", "viajesEspaciales", "astronauta");

        //  Request request = new Request("INSERT INTO Planetario (Planetario_Nombre) VALUES ('PRUEBA')", "planetario", "planetario");

        //  Request request = new Request("INSERT INTO Astronauta (Astronauta_Nombre, Astronauta_ProfesionId) VALUES ('PRUEBA', 1)", "viajesEspaciales", "astronauta");

        //  Request request = new Request("UPDATE Planetario SET Planetario_Nombre = 'KAKAPO'", "planetario", "planetario");

        //  Request request = new Request("UPDATE Astronauta SET Astronauta_Nombre = 'KAKAPO'", "viajesEspaciales", "astronauta");

        //  Request request = new Request("DELETE FROM Planetario", "planetario", "planetario");

        //  Request request = new Request("DELETE FROM Astronauta", "viajesEspaciales", "astronauta");

        //  loadBalancer.SELECT(request);
        //  loadBalancer.INSERT(request);
        //  loadBalancer.UPDATE(request, 2);
        //  loadBalancer.DELETE(request, 2);

        MenuPrincipal menu = new MenuPrincipal();

        //  menu.MostrarMenuPrincipal();
    }
}
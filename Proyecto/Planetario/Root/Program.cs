using NPlanetario.Data;
using NPlanetario.LoadBalancing;
using NPlanetario.Frontend;

internal class Program
{
    private static void Main(string[] args)
    {
        LoadBalancer loadBalancer = new LoadBalancer();
        //  Request request = new Request("SELECT Planeta_Id, Planeta_Nombre, Planeta_DistanciaSol, Planeta_PeriodoOrbital, Planeta_VelocidadOrbital, Planeta_InclinacionOrbital FROM Planeta", "planetario");
        //  Request request = new Request("SELECT Satelite_Id, Satelite_Nombre, Satelite_Excentricidad, Satelite_PeriodoOrbital, Satelite_InclinacionOrbital FROM Satelite", "planetario");
        //  Request request = new Request("SELECT  Planetario_Id, Planetario_Nombre FROM Planetario", "planetario", "planetario");

        //  Request request = new Request("SELECT Mision_Id, Mision_Nombre, Mision_Fecha, Mision_AstronautaId, Mision_ObjetivoId FROM Mision", "viajesEspaciales");
        //  Request request = new Request("SELECT Objetivo_Id, Objetivo_Nombre FROM Objetivo", "viajesEspaciales", "objetivo");
        //  Request request = new Request("SELECT Profesion_Id, Profesion_Nombre FROM Profesion", "viajesEspaciales", "profesion");
        //  Request request = new Request("SELECT Astronauta_Id, Astronauta_Nombre, Astronauta_ProfesionId FROM Astronauta", "viajesEspaciales", "astronauta");

        //  Request request = new Request("INSERT INTO Planeta (Planeta_Nombre, Planeta_DistanciaSol, Planeta_PeriodoOrbital, Planeta_VelocidadOrbital, Planeta_InclinacionOrbital) VALUES ('PRUEBA', 1.0, 1.0, 1.0, 1.0)", "planetario");
        //  Request request = new Request("INSERT INTO Satelite (Satelite_Nombre, Satelite_Excentricidad, Satelite_PeriodoOrbital, Satelite_InclinacionOrbital) VALUES ('L', 0.2, 0.2, 0.2)", "planetario", "satelite");
        //  Request request = new Request("INSERT INTO Planetario (Planetario_Nombre) VALUES ('PRUEBA')", "planetario", "planetario");

        //  Request request = new Request("INSERT INTO Mision (Mision_Nombre, Mision_Fecha, Mision_AstronautaId, Mision_ObjetivoId) VALUES ('PRUEBA', '1963-08-22 00:00:00.000', 1, 1)", "viajesEspaciales");
        //  Request request = new Request("INSERT INTO Objetivo (Objetivo_Nombre) VALUES ('PRUEBA')", "viajesEspaciales", "objetivo");
        //  Request request = new Request("INSERT INTO Profesion (Profesion_Nombre) VALUES ('PRUEBA')", "viajesEspaciales", "profesion");
        //  Request request = new Request("INSERT INTO Astronauta (Astronauta_Nombre, Astronauta_ProfesionId) VALUES ('PRUEBA', 1)", "viajesEspaciales", "astronauta");

        //  Request request = new Request("UPDATE Planeta SET Planeta_Nombre = 'KAKAPO'", "planetario");
        //  Request request = new Request("UPDATE Satelite SET Satelite_Nombre = 'PRUEBA'", "planetario", "satelite");
        //  Request request = new Request("UPDATE Planetario SET Planetario_Nombre = 'KAKAPO'", "planetario", "planetario");

        //  Request request = new Request("UPDATE Mision SET Mision_Nombre = 'Apolo 16'", "viajesEspaciales");
        //  Request request = new Request("UPDATE Objetivo SET Objetivo_Nombre = 'KAKAPO'", "viajesEspaciales", "objetivo");
        //  Request request = new Request("UPDATE Profesion SET Profesion_Nombre = 'KAKAPO'", "viajesEspaciales", "profesion");
        //  Request request = new Request("UPDATE Astronauta SET Astronauta_Nombre = 'KAKAPO'", "viajesEspaciales", "astronauta");

        //  Request request = new Request("DELETE FROM Planeta", "planetario");
        //  Request request = new Request("DELETE FROM Satelite", "planetario", "satelite");
        //  Request request = new Request("DELETE FROM Planetario", "planetario", "planetario");

        //  Request request = new Request("DELETE FROM Mision", "viajesEspaciales");
        //  Request request = new Request("DELETE FROM Objetivo", "viajesEspaciales", "objetivo");
        //  Request request = new Request("DELETE FROM Profesion", "viajesEspaciales", "profesion");
        //  Request request = new Request("DELETE FROM Astronauta", "viajesEspaciales", "astronauta");

        //  loadBalancer.SELECT(request);
        //  loadBalancer.INSERT(request);
        //  loadBalancer.UPDATE(request, 2);
        //  loadBalancer.DELETE(request, 2);

        MenuPrincipal menu = new MenuPrincipal();

        //  menu.MostrarMenuPrincipal();
    }
}
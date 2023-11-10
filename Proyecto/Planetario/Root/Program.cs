using Planetario.Data;
using Planetario.LoadBalancing;
using Planetario.Frontend;

internal class Program
{
    private static void Main(string[] args)
    {
        //  LoadBalancer loadBalancer = new LoadBalancer();
        //  Request request = new Request("SELECT Planeta_Id, Planeta_Nombre, Planeta_DistanciaSol, Planeta_PeriodoOrbital, Planeta_VelocidadOrbital, Planeta_InclinacionOrbital FROM Planeta", "planetario");
        //  Request request = new Request("SELECT Mision_Id, Mision_Nombre, Mision_Fecha, Mision_AstronautaId, Mision_ObjetivoId FROM Mision", "viajesEspaciales");
        //  Request request = new Request("INSERT INTO Planeta (Planeta_Nombre, Planeta_DistanciaSol, Planeta_PeriodoOrbital, Planeta_VelocidadOrbital, Planeta_InclinacionOrbital) VALUES ('PRUEBA', 1.0, 1.0, 1.0, 1.0)", "planetario");
        //  Request request = new Request("INSERT INTO Mision (Mision_Nombre, Mision_Fecha, Mision_AstronautaId, Mision_ObjetivoId) VALUES ('PRUEBA', '1963-08-22 00:00:00.000', 1, 1)", "viajesEspaciales");
        //  Request request = new Request("UPDATE Planeta SET Planeta_Nombre = 'KAKAPO'", "planetario");
        //  loadBalancer.SELECT(request);
        //  loadBalancer.INSERT(request);

        //  loadBalancer.UPDATE(request, 6);
        MenuPrincipal menu = new MenuPrincipal();

        //  menu.MostrarMenuPrincipal();
    }
}
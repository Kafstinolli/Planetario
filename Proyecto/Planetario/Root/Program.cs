using Planetario.Data;
using Planetario.LoadBalancing;
using Planetario.Frontend;

internal class Program
{
    private static void Main(string[] args)
    {
        // LoadBalancer loadBalancer = new LoadBalancer();
        // Request request = new Request("SELECT Planeta_Id, Planeta_Nombre, Planeta_DistanciaSol, Planeta_PeriodoOrbital, Planeta_VelocidadOrbital, Planeta_InclinacionOrbital FROM Planeta", "SELECT", "planetario");
        // Request request = new Request("INSERT INTO Planeta (Planeta_Nombre, Planeta_DistanciaSol, Planeta_PeriodoOrbital, Planeta_VelocidadOrbital, Planeta_InclinacionOrbital) VALUES ('PRUEBA', 1.0, 1.0, 1.0, 1.0)", "planetario");
        // Request request = new Request("SELECT Mision_Id, Mision_Nombre, Mision_Fecha, Mision_AstronautaId, Mision_ObjetivoId FROM Mision", "SELECT", "viajesEspaciales");
        // loadBalancer.SELECT(request);
        // loadBalancer.INSERT(request);

        MenuPrincipal menu = new MenuPrincipal();

        menu.MostrarMenuPrincipal();
    }
}
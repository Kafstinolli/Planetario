using Planetario.Data;
using Planetario.LoadBalancing;
using Planetario.Frontend;

internal class Program
{
    private static void Main(string[] args)
    {
        // LoadBalancer loadBalancer = new LoadBalancer();
        // Request request = new Request("SELECT Planeta_Id, Planeta_Nombre, Planeta_DistanciaSol, Planeta_PeriodoOrbital, Planeta_VelocidadOrbital, Planeta_InclinacionOrbital FROM Planeta", "SELECT", "planetario");
        // loadBalancer.prueba(request);

        MenuPrincipal menu = new MenuPrincipal();

        menu.MostrarMenuPrincipal();
    }
}
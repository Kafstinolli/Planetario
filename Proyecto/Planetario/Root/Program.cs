using Planetario.Data;
using Planetario.LoadBalancing;

internal class Program
{
    private static void Main(string[] args)
    {
        LoadBalancer loadBalancer = new LoadBalancer();
        Request request = new Request("SELECT Planeta_Id, Planeta_Nombre, Planeta_DistanciaSol, Planeta_PeriodoOrbital, Planeta_VelocidadOrbital, Planeta_InclinacionOrbital FROM Planeta", "SELECT", "planetario");
        loadBalancer.prueba(request);
        // Show(planetarioServer);
    }
}

public class Request
{
    public string Nombre { get; }
    public string Tipo { get; }

    public string Id { get; }

    public Request(string nombre, string tipo, string id)
    {
        Nombre = nombre;
        Tipo = tipo;
        Id = id;
    }
}

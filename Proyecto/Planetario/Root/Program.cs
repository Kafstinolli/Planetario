using Planetario.Data;
using Planetario.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        PlanetarioServer planetarioServer = new PlanetarioServer("softiRedsLaptop", "sa", "isabella12");

        Show(planetarioServer);
    }

    public static void Show(PlanetarioServer planetarioServer)
    {
        Console.Clear();

        List<Planeta> planetas = planetarioServer.GetAllPlanetas();

        foreach (Planeta planeta in planetas)
        {
            Console.WriteLine($"| {planeta.Nombre} | {planeta.DistanciaSol} | {planeta.PeriodoOrbital} | {planeta.VelocidadOrbital} | {planeta.InclinacionOrbital} |");
        }
    }
}
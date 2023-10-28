using Planetario.Data;
using Planetario.Models;

namespace Planetario.Backend;

public static class PlanetarioController
{
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
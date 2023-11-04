using Planetario.Data.Planetario;
using Planetario.Models.Planetario;

namespace Planetario.Backend;

public class PlanetarioController
{
    public void Show(PlanetarioServer planetarioServer, string query)
    {
        Console.Clear();

        List<Planeta> planetas = planetarioServer.GetAllPlanetas(query);

        foreach (Planeta planeta in planetas)
        {
            Console.WriteLine($"| {planeta.Nombre} | {planeta.DistanciaSol} | {planeta.PeriodoOrbital} | {planeta.VelocidadOrbital} | {planeta.InclinacionOrbital} |");
        }
    }
}
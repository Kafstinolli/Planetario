using Planetario.Data.Planetario;
using Planetario.Models.Planetario;

namespace Planetario.Backend.Planetario;

public class PlanetarioController
{
    public void Add(PlanetarioServer planetarioServer, string query)
    {
        Console.Clear();

        planetarioServer.CreatePlaneta(query);

        Console.WriteLine("Se creó el planeta correctamente");
    }
    
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
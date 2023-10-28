using Planetario.Data;
using Planetario.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        PlanetarioServer planetarioServer = new PlanetarioServer("softiRedsLaptop", "sa", "isabella12");

        Show(planetarioServer);
    }
}
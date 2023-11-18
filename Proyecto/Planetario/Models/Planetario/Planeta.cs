namespace NPlanetario.Models.MPlanetario;

public class Planeta
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public double DistanciaSol { get; set; }
    public double PeriodoOrbital { get; set; }
    public double VelocidadOrbital { get; set; }
    public double InclinacionOrbital { get; set; }

    public Planeta(int id, string nombre, double distanciaSol, double periodoOrbital, double velocidadOrbital, double inclinacionOrbital)
    {
        Id = id;
        Nombre = nombre;
        DistanciaSol = distanciaSol;
        PeriodoOrbital = periodoOrbital;
        VelocidadOrbital = velocidadOrbital;
        InclinacionOrbital = inclinacionOrbital;
    }
}
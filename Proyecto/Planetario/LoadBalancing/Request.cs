namespace Planetario.LoadBalancing;

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
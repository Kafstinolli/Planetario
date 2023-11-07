namespace Planetario.LoadBalancing;

public class Request
{
    public string Query { get; }
    public string Tipo { get; }

    public string Id { get; }

    public Request(string query, string tipo, string id)
    {
        Query = query;
        Tipo = tipo;
        Id = id;
    }
}
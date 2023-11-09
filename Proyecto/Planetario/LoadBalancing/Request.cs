namespace Planetario.LoadBalancing;

public class Request
{
    public string Query { get; }
    public string Id { get; }

    public Request(string query, string id)
    {
        Query = query;
        Id = id;
    }
}
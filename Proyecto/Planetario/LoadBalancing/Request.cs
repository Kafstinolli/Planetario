namespace NPlanetario.LoadBalancing;

public class Request
{
    public string Query { get; }
    public string Id { get; }
    public string Model {  get; } 

    public Request(string query, string id, string model)
    {
        Query = query;
        Id = id;
        Model = model;
    }
}
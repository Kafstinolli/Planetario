using System.Data.SqlClient;

public class PlanetarioServer : PlanetarioConnection
{
    public PlanetarioServer(string server, string user, string password) : base(server, user, password) { }

    public List<Planeta> GetAllPlanetas()
    {
        Connect();
        List<Planeta> planetas = new List<Planeta>();
        string query = "SELECT * FROM Planetas";
        SqlCommand command = new SqlCommand(query, _connection);

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
        }
        CloseConnection();

        return planetas;
    }
}
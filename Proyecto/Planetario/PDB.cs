using System.Data.SqlClient;

public class PDB : PlanetarioDB
{
    public PDB(string server, string user, string password) : base(server, user, password) { }

    public List<Planeta> GetAllPlanetas()
    {
        Connect();
        List<Planeta> planetas = new List<Planeta>();
        string query = "SELECT * FROM Planetas";
        SqlCommand command = new SqlCommand(query, _connection);

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            x
        }
        CloseConnection();

        return planetas;
    }
}
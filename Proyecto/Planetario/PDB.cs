using System.Data.SqlClient;

public class PDB : PlanetarioDB
{
    public PDB(string server, string user, string password) : base(server, user, password) { }

    public void GetAllPlanetas()
    {
        Connect();

        string query = "SELECT * FROM Planetas";
        SqlCommand command = new SqlCommand(query, _connection);

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {

        }

        CloseConnection();
    }
}
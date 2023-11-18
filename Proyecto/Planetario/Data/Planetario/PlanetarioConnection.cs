using System.Data.SqlClient;

namespace NPlanetario.Data.DPlanetario;

public abstract class PlanetarioConnection
{
    private string _connectionString;
    protected SqlConnection _connection;

    public PlanetarioConnection(string server, string user, string password)
    {
        _connectionString = $"Data Source={server}; Initial Catalog=Planetario; User={user};Password={password}";
    }

    public void Connect()
    {
        _connection = new SqlConnection(_connectionString);
        _connection.Open();
    }

    public void CloseConnection()
    {
        if (_connection != null && _connection.State == System.Data.ConnectionState.Open) _connection.Close();
    }
}
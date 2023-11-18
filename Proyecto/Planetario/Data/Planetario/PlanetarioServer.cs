using System.Data.SqlClient;
using NPlanetario.Models.MPlanetario;

namespace NPlanetario.Data.DPlanetario;

public class PlanetarioServer : PlanetarioConnection
{
    public PlanetarioServer(string server, string user, string password) : base(server, user, password) { }

    //  Planeta
    public void CreatePlaneta(string query)
    {
        Connect();

        SqlCommand command = new SqlCommand(query, _connection);
        command.ExecuteNonQuery();

        CloseConnection();
    }

    public List<Planeta> ReadPlanetas(string query)
    {
        Connect();

        List<Planeta> planetas = new List<Planeta>();
        SqlCommand command = new SqlCommand(query, _connection);

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            int id = reader.GetInt32(0);
            string nombre = reader.GetString(1);
            double distanciaSol = reader.GetDouble(2);
            double periodoOrbital = reader.GetDouble(3);
            double velocidadOrbital = reader.GetDouble(4);
            double inclinacionOrbital = reader.GetDouble(5);

            planetas.Add(new Planeta(id, nombre, distanciaSol, periodoOrbital, velocidadOrbital, inclinacionOrbital));
        }

        CloseConnection();

        return planetas;
    }

    public void UpdatePlaneta(string query)
    {
        Connect();

        SqlCommand command = new SqlCommand(query, _connection);
        command.ExecuteNonQuery();

        CloseConnection();
    }

    public void DeletePlaneta(string query)
    {
        Connect();

        SqlCommand command = new SqlCommand(query, _connection);
        command.ExecuteNonQuery();

        CloseConnection();
    }

    //  Satelite
    public void CreateSatelite(string query)
    {
        Connect();

        SqlCommand command = new SqlCommand(query, _connection);
        command.ExecuteNonQuery();

        CloseConnection();
    }

    public List<Satelite> ReadSatelites(string query)
    {
        Connect();

        List<Satelite> satelites = new List<Satelite>();
        SqlCommand command = new SqlCommand(query, _connection);

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            int id = reader.GetInt32(0);
            string nombre = reader.GetString(1);
            double excentricidad = reader.GetDouble(2);
            double periodoOrbital = reader.GetDouble(3);
            double inclinacionOrbital = reader.GetDouble(4);

            satelites.Add(new Satelite(id, nombre, excentricidad, periodoOrbital, inclinacionOrbital));
        }

        CloseConnection();

        return satelites;
    }

    public void UpdateSatelite(string query)
    {
        Connect();

        SqlCommand command = new SqlCommand(query, _connection);
        command.ExecuteNonQuery();

        CloseConnection();
    }

    public void DeleteSatelite(string query)
    {
        Connect();

        SqlCommand command = new SqlCommand(query, _connection);
        command.ExecuteNonQuery();

        CloseConnection();
    }

    //  Planetario
    public void CreatePlanetario(string query)
    {
        Connect();

        SqlCommand command = new SqlCommand(query, _connection);
        command.ExecuteNonQuery();

        CloseConnection();
    }

    public List<Planetario> ReadPlanetarios(string query)
    {
        Connect();

        List<NPlanetario> planetarios = new List<NPlanetario>();
        SqlCommand command = new SqlCommand(query, _connection);

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            int id = reader.GetInt32(0);
            string nombre = reader.GetString(1);
            
            planetarios.Add(new Planetario(id, nombre));
        }

        CloseConnection();

        return planetarios;
    }

    public void UpdatePlanetario(string query)
    {
        Connect();

        SqlCommand command = new SqlCommand(query, _connection);
        command.ExecuteNonQuery();

        CloseConnection();
    }

    public void DeletePlanetario(string query)
    {
        Connect();

        SqlCommand command = new SqlCommand(query, _connection);
        command.ExecuteNonQuery();

        CloseConnection();
    }
}
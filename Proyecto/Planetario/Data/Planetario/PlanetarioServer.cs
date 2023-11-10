using System.Data.SqlClient;
using Planetario.Models.Planetario;

namespace Planetario.Data.Planetario;

public class PlanetarioServer : PlanetarioConnection
{
    public PlanetarioServer(string server, string user, string password) : base(server, user, password) { }

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
}
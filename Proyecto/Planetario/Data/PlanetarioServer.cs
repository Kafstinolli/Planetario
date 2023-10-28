using System.Data.SqlClient;

public class PlanetarioServer : PlanetarioConnection
{
    public PlanetarioServer(string server, string user, string password) : base(server, user, password) { }

    public List<Planeta> GetAllPlanetas()
    {
        Connect();

        List<Planeta> planetas = new List<Planeta>();
        string query = "SELECT Planeta_Id, Planeta_Nombre, Planeta_DistanciaSol, Planeta_PeriodoOrbital, Planeta_VelocidadOrbital, Planeta_InclinacionOrbital FROM Planeta";
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
}
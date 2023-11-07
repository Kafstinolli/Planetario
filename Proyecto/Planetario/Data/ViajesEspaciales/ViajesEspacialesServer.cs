using Planetario.Models.ViajesEspaciales;
using System.Data.SqlClient;

namespace Planetario.Data.ViajesEspaciales
{
    public class ViajesEspacialesServer : ViajesEspacialesConnection
    {
        public ViajesEspacialesServer(string server, string user, string password) : base(server, user, password){ }

        public List<Mision> GetAllMisiones(string query)
        {
            Connect();

            List<Mision> misiones = new List<Mision>();
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(1);
                DateTime fecha = reader.GetDateTime(2);
                int astronautaId = reader.GetInt32(3);
                int objetivoId = reader.GetInt32(4);

                misiones.Add(new Mision(id, nombre, fecha, astronautaId, objetivoId));
            }

            CloseConnection();

            return misiones;
        } 
    }
}

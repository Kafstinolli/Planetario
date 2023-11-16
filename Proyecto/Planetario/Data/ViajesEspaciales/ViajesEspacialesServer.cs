using Planetario.Models.ViajesEspaciales;
using System.Data.SqlClient;

namespace Planetario.Data.ViajesEspaciales
{
    public class ViajesEspacialesServer : ViajesEspacialesConnection
    {
        public ViajesEspacialesServer(string server, string user, string password) : base(server, user, password){ }

        //  Mision
        public void CreateMision(string query)
        {
            Connect();

            SqlCommand command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public List<Mision> ReadMisiones(string query)
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

        public void UpdateMision(string query)
        {
            Connect();

            SqlCommand command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void DeleteMision(string query) 
        {  
            Connect();

            SqlCommand command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        //  Objetivo
        public void CreateObjetivo(string query)
        {
            Connect();

            SqlCommand command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public List<Objetivo> ReadObjetivos(string query)
        {
            Connect();

            List<Objetivo> objetivos = new List<Objetivo>();
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(1);

                objetivos.Add(new Objetivo(id, nombre));
            }

            CloseConnection();

            return objetivos;
        }

        public void UpdateObjetivo(string query)
        {
            Connect();

            SqlCommand command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void DeleteObjetivo(string query)
        {
            Connect();

            SqlCommand command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();

            CloseConnection();
        }
    }
}

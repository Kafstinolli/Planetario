using NPlanetario.Models.ViajesEspaciales;
using System.Data.SqlClient;

namespace NPlanetario.Data.ViajesEspaciales
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

        //  Profesion
        public void CreateProfesion(string query)
        {
            Connect();

            SqlCommand command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public List<Profesion> ReadProfesiones(string query)
        {
            Connect();

            List<Profesion> profesiones = new List<Profesion>();
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(1);

                profesiones.Add(new Profesion(id, nombre));
            }

            CloseConnection();

            return profesiones;
        }

        public void UpdateProfesion(string query)
        {
            Connect();

            SqlCommand command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void DeleteProfesion(string query)
        {
            Connect();

            SqlCommand command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        //  Astronauta
        public void CreateAstronauta(string query)
        {
            Connect();

            SqlCommand command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public List<Astronauta> ReadAstronautas(string query)
        {
            Connect();

            List<Astronauta> astronautas = new List<Astronauta>();
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(1);
                int idProfesion = reader.GetInt32(2);

                astronautas.Add(new Astronauta(id, nombre, idProfesion));
            }

            CloseConnection();

            return astronautas;
        }

        public void UpdateAstronauta(string query)
        {
            Connect();

            SqlCommand command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();

            CloseConnection();
        }

        public void DeleteAstronauta(string query)
        {
            Connect();

            SqlCommand command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();

            CloseConnection();
        }
    }
}

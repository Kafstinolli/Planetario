using System.Data.SqlClient;

namespace Planetario.Data.ViajesEspaciales
{
    public class ViajesEspacialesConnection
    {
        private string _connectionString;
        protected SqlConnection _connection;

        public ViajesEspacialesConnection(string server, string user, string password)
        {
            _connectionString = $"Data Source={server};Initial Catalog=ViajesEspaciales;User Id={user};Password={password}";
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
}

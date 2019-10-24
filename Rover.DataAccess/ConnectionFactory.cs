using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Rover.DataAccess
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly string _roverConnectionString;
        
        public ConnectionFactory()
        {
            var appConfig = ConfigurationManager.AppSettings;

            string dbname = appConfig["RD_DB_NAME"];
            
            //if (string.IsNullOrEmpty(dbname)) return null;

            string username = appConfig["RDS_USERNAME"];
            string password = appConfig["RDS_PASSWORD"];
            string hostname = appConfig["RDS_HOSTNAME"];
            string port = appConfig["RDS_PORT"];

            _roverConnectionString = "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }

        public IDbConnection ConnectRover()
        {
            var connection = new SqlConnection(_roverConnectionString);
            connection.Open();
            return connection;
        }
    }
}
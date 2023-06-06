using System.Data.SqlClient;

namespace SingleResponsibility
{
    public class DbOperations
    {
        private SqlConnection sqlConnection = null;
        public DbOperations(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int ExecuteCommand(string commandText, Dictionary<string, object> parameters)
        {

            return 1;
        }
    }
}

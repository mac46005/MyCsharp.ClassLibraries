using DataManipulation.ClassLib.Interfaces;
using System.Configuration;
using System.Data.SqlClient;

namespace DataManipulation.ClassLib.Services.Dapper{
    public class SqlDesignTimeDbContextFactory
    {
        private SqlConnection sqlConnection;
        private string GetConnectionString(string connectionName){
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }



    }
}
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManipulation.ClassLib.Services.SqlDataAccess.Dapper
{
    public class SqlDataAccess : IDisposable
    {
        private string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public async Task<IEnumerable<T>> LoadData<T,U>(string storedProcedure,U parameters,string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var entities = await connection.QueryAsync<T>(storedProcedure,parameters,commandType: CommandType.StoredProcedure);
                return entities;
            }
        }

        public async Task SaveData<T>(string storedProcedure,T parameters,string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        } 





        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

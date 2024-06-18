using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dapper Wrapper mostly exists for testing purposes
namespace Infrastructure.Dapper
{
    public class DapperWrapper : IDapperWrapper
    {
        public async Task<int> ExecuteAsync(IDbConnection connection, string sql, object parameters)
        {
            return await connection.ExecuteAsync(sql, parameters);
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(IDbConnection connection, string sql, object? param = null)
        {
            return await connection.QueryAsync<T>(sql, param);
        }

        public async Task<T> QueryFirstAsync<T>(IDbConnection connection, string sql, object? param = null)
        {
            return await connection.QueryFirstAsync<T>(sql, param);
        }

        public async Task<T?> QueryFirstOrDefaultAsync<T>(IDbConnection connection, string sql, object? param = null)
        {
            return await connection.QueryFirstOrDefaultAsync<T>(sql, param);
        }
    }
}

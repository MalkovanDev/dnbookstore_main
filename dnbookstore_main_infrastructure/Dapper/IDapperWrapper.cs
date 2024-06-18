using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dapper Wrapper mostly exists for testing purposes
namespace Infrastructure.Dapper
{
    public interface IDapperWrapper
    {
        Task<int> ExecuteAsync(IDbConnection connection, string sql, object parameters);

        Task<IEnumerable<T>> QueryAsync<T>(IDbConnection connection, string sql, object? parameters = null);
        Task<T> QueryFirstAsync<T>(IDbConnection connection, string sql, object? param = null);
        Task<T?> QueryFirstOrDefaultAsync<T>(IDbConnection connection, string sql, object? param = null);
    }
}

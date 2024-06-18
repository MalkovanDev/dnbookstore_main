using Infrastructure.Databases.Interfaces;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Databases.dnBookstore
{
    public class DnBookstoreDatabaseContext : IDatabaseContext
    {
        //private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DnBookstoreDatabaseContext(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("dnBookstore");
            if(connectionString == null)
                throw new ArgumentNullException(nameof(connectionString));

            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}

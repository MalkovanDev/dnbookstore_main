using System.Data;

namespace Infrastructure.Databases.Interfaces
{
    public interface IDatabaseContext
    {
        IDbConnection CreateConnection();
    }
}
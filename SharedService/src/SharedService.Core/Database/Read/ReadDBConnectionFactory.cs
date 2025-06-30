using System.Data;
using Npgsql;
using SharedService.Core.Database.Intefraces;

namespace SharedService.Core.Database.Read;

public class ReadDBConnectionFactory : IDBConnectionFactory
{
    private readonly string _connectionString;

    public ReadDBConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IDbConnection Create()
    {
        return new NpgsqlConnection(_connectionString);
    }
}
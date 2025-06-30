using System.Data;

namespace SharedService.Core.Database.Intefraces;

public interface IDBConnectionFactory
{
    public IDbConnection Create();
}
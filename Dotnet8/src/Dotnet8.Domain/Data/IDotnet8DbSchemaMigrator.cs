using System.Threading.Tasks;

namespace Dotnet8.Data;

public interface IDotnet8DbSchemaMigrator
{
    Task MigrateAsync();
}

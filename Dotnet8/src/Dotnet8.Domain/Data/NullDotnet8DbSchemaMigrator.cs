using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Dotnet8.Data;

/* This is used if database provider does't define
 * IDotnet8DbSchemaMigrator implementation.
 */
public class NullDotnet8DbSchemaMigrator : IDotnet8DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

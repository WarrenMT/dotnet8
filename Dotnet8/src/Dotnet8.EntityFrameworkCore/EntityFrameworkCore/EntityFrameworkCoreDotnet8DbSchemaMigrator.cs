using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Dotnet8.Data;
using Volo.Abp.DependencyInjection;

namespace Dotnet8.EntityFrameworkCore;

public class EntityFrameworkCoreDotnet8DbSchemaMigrator
    : IDotnet8DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDotnet8DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the Dotnet8DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Dotnet8DbContext>()
            .Database
            .MigrateAsync();
    }
}

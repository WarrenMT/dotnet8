using Dotnet8.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Dotnet8.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Dotnet8EntityFrameworkCoreModule),
    typeof(Dotnet8ApplicationContractsModule)
    )]
public class Dotnet8DbMigratorModule : AbpModule
{
}

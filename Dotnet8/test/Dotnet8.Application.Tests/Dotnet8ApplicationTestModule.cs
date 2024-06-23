using Volo.Abp.Modularity;

namespace Dotnet8;

[DependsOn(
    typeof(Dotnet8ApplicationModule),
    typeof(Dotnet8DomainTestModule)
)]
public class Dotnet8ApplicationTestModule : AbpModule
{

}

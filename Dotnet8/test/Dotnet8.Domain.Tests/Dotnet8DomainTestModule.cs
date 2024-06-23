using Volo.Abp.Modularity;

namespace Dotnet8;

[DependsOn(
    typeof(Dotnet8DomainModule),
    typeof(Dotnet8TestBaseModule)
)]
public class Dotnet8DomainTestModule : AbpModule
{

}

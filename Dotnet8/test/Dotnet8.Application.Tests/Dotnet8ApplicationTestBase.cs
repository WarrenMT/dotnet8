using Volo.Abp.Modularity;

namespace Dotnet8;

public abstract class Dotnet8ApplicationTestBase<TStartupModule> : Dotnet8TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

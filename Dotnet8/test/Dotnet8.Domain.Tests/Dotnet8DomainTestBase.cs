using Volo.Abp.Modularity;

namespace Dotnet8;

/* Inherit from this class for your domain layer tests. */
public abstract class Dotnet8DomainTestBase<TStartupModule> : Dotnet8TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

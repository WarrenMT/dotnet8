using Xunit;

namespace Dotnet8.EntityFrameworkCore;

[CollectionDefinition(Dotnet8TestConsts.CollectionDefinitionName)]
public class Dotnet8EntityFrameworkCoreCollection : ICollectionFixture<Dotnet8EntityFrameworkCoreFixture>
{

}

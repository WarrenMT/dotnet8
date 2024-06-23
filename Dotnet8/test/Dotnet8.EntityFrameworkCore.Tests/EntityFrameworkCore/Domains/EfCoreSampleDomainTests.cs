using Dotnet8.Samples;
using Xunit;

namespace Dotnet8.EntityFrameworkCore.Domains;

[Collection(Dotnet8TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<Dotnet8EntityFrameworkCoreTestModule>
{

}

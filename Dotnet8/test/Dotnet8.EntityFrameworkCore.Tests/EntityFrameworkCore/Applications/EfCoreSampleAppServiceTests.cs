using Dotnet8.Samples;
using Xunit;

namespace Dotnet8.EntityFrameworkCore.Applications;

[Collection(Dotnet8TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<Dotnet8EntityFrameworkCoreTestModule>
{

}

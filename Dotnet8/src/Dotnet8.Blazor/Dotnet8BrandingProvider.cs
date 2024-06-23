using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Dotnet8.Blazor;

[Dependency(ReplaceServices = true)]
public class Dotnet8BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Dotnet8";
}

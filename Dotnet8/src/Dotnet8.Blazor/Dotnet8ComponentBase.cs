using Dotnet8.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Dotnet8.Blazor;

public abstract class Dotnet8ComponentBase : AbpComponentBase
{
    protected Dotnet8ComponentBase()
    {
        LocalizationResource = typeof(Dotnet8Resource);
    }
}

using Dotnet8.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Dotnet8.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Dotnet8Controller : AbpControllerBase
{
    protected Dotnet8Controller()
    {
        LocalizationResource = typeof(Dotnet8Resource);
    }
}

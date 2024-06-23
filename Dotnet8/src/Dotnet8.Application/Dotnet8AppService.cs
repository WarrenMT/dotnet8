using System;
using System.Collections.Generic;
using System.Text;
using Dotnet8.Localization;
using Volo.Abp.Application.Services;

namespace Dotnet8;

/* Inherit your application services from this class.
 */
public abstract class Dotnet8AppService : ApplicationService
{
    protected Dotnet8AppService()
    {
        LocalizationResource = typeof(Dotnet8Resource);
    }
}

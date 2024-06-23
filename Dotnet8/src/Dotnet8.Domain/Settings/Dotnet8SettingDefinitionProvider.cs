using Volo.Abp.Settings;

namespace Dotnet8.Settings;

public class Dotnet8SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(Dotnet8Settings.MySetting1));
    }
}

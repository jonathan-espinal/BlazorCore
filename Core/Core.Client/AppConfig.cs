using Core.Framework.Common.Lib.I18N;

namespace Core.Client;

public class AppConfig : Framework.Common.Settings.AppConfig, Framework.Common.Settings.IAppConfig {
    public AppConfig(I18N i18n) : base(i18n) { }
}

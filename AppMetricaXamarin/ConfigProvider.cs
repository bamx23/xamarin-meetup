using System;
namespace AppMetricaXamarin
{
	public class ConfigProvider
	{
		public static YandexMetricaPCL.YandexMetricaConfig Config()
		{
			return new YandexMetricaPCL.YandexMetricaConfig(ApiKeyProvider.ApiKey())
			{
				ReportCrashesEnabled = true,
				SessionTimeout = 5 * 60,
			};
		}
	}
}

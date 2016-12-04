using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AppMetricaXamarin
{
	public class AppMetricaApiLoader
	{
		private const string BaseUrl = "https://beta.api-appmetrika.yandex.ru/stat/v1";
		private const string DataPath = "/data";
		private const string DrilldownPath = DataPath + "/drilldown";

		private const string DateFormat = "yyyy-MM-dd";
		private const string DefaultDate = "today";

		private HttpClient _client;

		public string AppId { get; private set; }
		public string AuthToken { get; private set; }

		public AppMetricaApiLoader(string appId, string authToken)
		{
			_client = new HttpClient
			{
				Timeout = TimeSpan.FromSeconds(15),
				MaxResponseContentBufferSize = 256000,
			};

			AppId = appId;
			AuthToken = authToken;
		}

		protected Uri DataUri(Dictionary<string, string> parameters, DateTime? fromDate = null, DateTime? toDate = null)
		{
			var fullParameters = new Dictionary<string, string>(parameters);

			fullParameters["ids"] = AppId;
			fullParameters["oauth_token"] = AuthToken;
			fullParameters["date1"] = fromDate?.ToString(DateFormat) ?? DefaultDate;
			fullParameters["date2"] = toDate?.ToString(DateFormat) ?? DefaultDate;

			var query = fullParameters
				.Select(kvp => string.Format("{0}={1}", Uri.EscapeDataString(kvp.Key), Uri.EscapeDataString(kvp.Value)))
				.Aggregate((a, b) => string.Format("{0}&{1}", a, b));

			var drilldown = fullParameters.ContainsKey("parent_id");
			var url = string.Format("{0}{1}?{2}", BaseUrl, (drilldown ? DrilldownPath : DataPath), query);

			return new Uri(url);
		}

		protected async Task<JObject> GetJSONObject(Uri uri)
		{
			JObject jsonObject = null;

			var response = await _client.GetAsync(uri);
			if (response.IsSuccessStatusCode)
			{
				var jsonString = await response.Content.ReadAsStringAsync();
				if (jsonString != null)
				{
					jsonObject = JObject.Parse(jsonString);
				}
			}

			return jsonObject;
		}

		public async Task<Dictionary<string, double>> LoadUserInfo(string key, DateTime? toDate = null, DateTime? fromDate = null)
		{
			var parameters = new Dictionary<string, string>
			{
				{ "metrics", "ym:m:devices,ym:m:clientEvents" },
				{ "dimensions", "ym:m:eventLabel,ym:m:paramsLevel1,ym:m:paramsLevel2" },
				{ "parent_id", string.Format("[\"user-info\",\"{0}\"]", key) },
			};
			var uri = DataUri(parameters, toDate, fromDate);
			var jsonObject = await GetJSONObject(uri);

			Dictionary<string, double> results = null;
			if (jsonObject != null)
				results = jsonObject["data"]
					.Select(n => new { Name = (string)n["dimension"]["name"], Value = (double)n["metrics"][1] })
					.Where(d => d.Value > 0)
					.ToDictionary(d => d.Name, d => d.Value);

			return results;
		}

		public async Task<Dictionary<string, double>> LoadSystemInfo(string key, bool showUndefined = false, DateTime? toDate = null, DateTime? fromDate = null)
		{
			var parameters = new Dictionary<string, string>
			{
				{ "metrics", "ym:m:users" },
				{ "dimensions", string.Format("ym:m:{0}", key) },
				{ "include_undefined", showUndefined ? "true" : "false" },
			};
			var uri = DataUri(parameters, toDate, fromDate);
			var jsonObject = await GetJSONObject(uri);

			Dictionary<string, double> results = null;
			if (jsonObject != null)
				results = jsonObject["data"]
					.Select(n => new { Name = (string)n["dimensions"][0]["name"], Value = (double)n["metrics"][0] })
					.Where(d => d.Value > 0)
					.ToDictionary(d => d.Name, d => d.Value);

			return results;
		}
	}
}

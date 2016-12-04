using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using YandexMetricaPCL;

namespace AppMetricaXamarin
{
	public partial class AppMetricaXamarinPage : ContentPage
	{
		protected AppMetricaApiLoader _loader;

		public List<ResultModel> ResultPlots { get; protected set; }

		public AppMetricaXamarinPage()
		{
			InitializeComponent();
			InitializeVisibility();
			InitializeBinding();
		}

		void InitializeVisibility()
		{
			sendButton.IsEnabled = false;

			voteView.IsVisible = true;
			resultsView.IsVisible = false;
		}

		void InitializeBinding()
		{
			_loader = new AppMetricaApiLoader(ApiKeyProvider.AppID(), ApiKeyProvider.AuthToken());

			BindingContext = this;
		}

		async void PickerSelectedIndexChanged(object sender, System.EventArgs e)
		{
			bool shouldLoad = sendButton.IsEnabled == false;

			sendButton.IsEnabled = true;

			if (shouldLoad)
				await UpdateResults();
		}

		async Task UpdateResults()
		{
			updateButton.IsEnabled = false;

			var date = DateTime.Now.AddDays(-5);
			plotsCarousel.ItemsSource = ResultPlots = await LoadResults(date);

			updateButton.IsEnabled = true;
		}

		async Task<List<ResultModel>> LoadResults(DateTime? fromDate = null, DateTime? toDate = null)
		{
			var results = new List<ResultModel>
			{
				new ResultModel
				{
					Title = "Пол",
					Data = await _loader.LoadUserInfo("gender", fromDate, toDate),
				},
				new ResultModel
				{
					Title = "Предпочитают",
					Data = await _loader.LoadUserInfo("animal", fromDate, toDate),
				},
				new ResultModel
				{
					Title = "Используют",
					Data = await _loader.LoadUserInfo("os", fromDate, toDate),
				},
				new ResultModel
				{
					Title = "Мобильная ОС",
					Data = await _loader.LoadSystemInfo("operatingSystem", false, fromDate, toDate),
				},
				new ResultModel
				{
					Title = "Предсказанный пол",
					Data = await _loader.LoadSystemInfo("gender", true, fromDate, toDate),
				},
				new ResultModel
				{
					Title = "Предсказанный возраст",
					Data = await _loader.LoadSystemInfo("ageInterval", true, fromDate, toDate),
				},
			};
			return results.Where(r => r.Data != null).ToList();
		}

		void SendButtonClicked(object sender, System.EventArgs e)
		{
			var results = new Dictionary<string, string>();
			AddResult(results, "gender", genderPicker);
			AddResult(results, "animal", animalPicker);
			AddResult(results, "os", osPicker);

			YandexMetrica.Implementation.ReportEvent("user-info", results);

			voteView.IsVisible = false;
			resultsView.IsVisible = true;
		}

		async void UpdateResultsClicked(object sender, System.EventArgs e)
		{
			await UpdateResults();
		}

		static void AddResult(Dictionary<string, string> results, string key, Picker picker)
		{
			if (picker.SelectedIndex < 0)
				return;

			results[key] = picker.Items[picker.SelectedIndex];
		}
	}
}

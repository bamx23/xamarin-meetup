using System;
using System.Collections.Generic;
using Xamarin.Forms;
using YandexMetricaPCL;

namespace AppMetricaXamarin
{
	public partial class AppMetricaXamarinPage : ContentPage
	{
		public List<string> ResultPlots { get; protected set; }

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
			ResultPlots = new List<string> { "График 1", "График 2" };

			BindingContext = this;
		}

		void PickerSelectedIndexChanged(object sender, System.EventArgs e)
		{
			sendButton.IsEnabled = true;
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

		static void AddResult(Dictionary<string, string> results, string key, Picker picker)
		{
			if (picker.SelectedIndex < 0)
				return;

			results[key] = picker.Items[picker.SelectedIndex];
		}
	}
}

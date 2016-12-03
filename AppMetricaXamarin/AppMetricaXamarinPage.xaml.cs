using System.Collections.Generic;
using Xamarin.Forms;
using YandexMetricaPCL;

namespace AppMetricaXamarin
{
	public partial class AppMetricaXamarinPage : ContentPage
	{
		public AppMetricaXamarinPage()
		{
			InitializeComponent();

			sendButton.IsEnabled = false;

			voteView.IsVisible = true;
			thanksLabel.IsVisible = false;
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
			thanksLabel.IsVisible = true;
		}

		static void AddResult(Dictionary<string, string> results, string key, Picker picker)
		{
			if (picker.SelectedIndex < 0)
				return;

			results[key] = picker.Items[picker.SelectedIndex];
		}
	}
}

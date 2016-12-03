using System;
using System.Collections.Generic;
using Xamarin.Forms;
using YandexMetricaPCL;

namespace AppMetricaXamarin
{
	public partial class AppMetricaXamarinPage : ContentPage
	{
		public List<OxyPlot.PlotModel> ResultPlots { get; protected set; }

		public AppMetricaXamarinPage()
		{
			InitializeComponent();
			InitializeVisibility();
			InitializeBinding();
		}

		void InitializeVisibility()
		{
			sendButton.IsEnabled = false;

			voteView.IsVisible = false;
			resultsView.IsVisible = true;
		}

		void InitializeBinding()
		{
			ResultPlots = new List<OxyPlot.PlotModel> { 
				new OxyPlot.PlotModel {
					Title = "Пол",
				},
				new OxyPlot.PlotModel {
					Title = "Любят"
				},
			};

			var genderStubSeries = new OxyPlot.Series.PieSeries();
			genderStubSeries.Slices.Add(new OxyPlot.Series.PieSlice("Мальчик", 32));
			genderStubSeries.Slices.Add(new OxyPlot.Series.PieSlice("Девочка", 23));
			ResultPlots[0].Series.Add(genderStubSeries);

			var animalStubSeries = new OxyPlot.Series.PieSeries();
			animalStubSeries.Slices.Add(new OxyPlot.Series.PieSlice("Собак", 15));
			animalStubSeries.Slices.Add(new OxyPlot.Series.PieSlice("Кошек", 17));
			animalStubSeries.Slices.Add(new OxyPlot.Series.PieSlice("Черепах", 2));
			ResultPlots[1].Series.Add(animalStubSeries);

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

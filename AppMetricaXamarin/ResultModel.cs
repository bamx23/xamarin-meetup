using System;
using System.Collections.Generic;

namespace AppMetricaXamarin
{
	public class ResultModel
	{
		public string Title { get; set; }
		public Dictionary<string, double> Data { get; set; }

		public OxyPlot.PlotModel PlotModel
		{
			get
			{
				var model = new OxyPlot.PlotModel
				{
					Title = Title,
				};
				var series = new OxyPlot.Series.PieSeries
				{
					OutsideLabelFormat = "{2:0.0}% ({0:0})",
				};
				foreach (var kvp in Data)
				{
					series.Slices.Add(new OxyPlot.Series.PieSlice(kvp.Key, kvp.Value));
				}
				model.Series.Add(series);
				return model;
			}
		}
	}
}

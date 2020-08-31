using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GettingStartedSample.ViewModel
{
	public class ViewModel
	{
		public ObservableCollection<ChartDataPoint> DateTimeRangeData { get; set; }

		public ViewModel()
		{
			DateTimeRangeData = new ObservableCollection<ChartDataPoint>
			{
				new ChartDataPoint(new DateTime(2015, 01, 1), 14),
				new ChartDataPoint(new DateTime(2015, 02, 1), 54),
				new ChartDataPoint(new DateTime(2015, 03, 1), 23),
				new ChartDataPoint(new DateTime(2015, 04, 1), 53),
				new ChartDataPoint(new DateTime(2015, 05, 1), 25),
				new ChartDataPoint(new DateTime(2015, 06, 1), 32),
				new ChartDataPoint(new DateTime(2015, 07, 1), 78),
				new ChartDataPoint(new DateTime(2015, 08, 1), 100),
				new ChartDataPoint(new DateTime(2015, 09, 1), 55),
				new ChartDataPoint(new DateTime(2015, 10, 1), 38),
				new ChartDataPoint(new DateTime(2015, 11, 1), 27),
				new ChartDataPoint(new DateTime(2015, 12, 1), 56),
				new ChartDataPoint(new DateTime(2015, 12, 31), 35)
			};
		}
	}

}

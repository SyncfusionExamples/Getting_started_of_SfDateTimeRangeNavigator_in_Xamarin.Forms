using Syncfusion.RangeNavigator.XForms;
using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GettingStartedSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

         
            if (Device.RuntimePlatform == Device.Android)
            {
                RangeNavigator.HeightRequest = 150;
            }
            else if (Device.RuntimePlatform == Device.iOS)
            {
                RangeNavigator.HeightRequest = 100;
            }
            else if (Device.RuntimePlatform == Device.UWP && Device.Idiom == TargetIdiom.Phone)
            {
                chart.Margin = new Thickness(5);
                RangeNavigator.Margin = new Thickness(5);
                RangeNavigator.Intervals = Syncfusion.RangeNavigator.XForms.DateTimeIntervalType.Quarter |
                                           Syncfusion.RangeNavigator.XForms.DateTimeIntervalType.Month;
                RangeNavigator.TooltipFormat = "dd/MM/yy";
                RangeNavigator.LeftTooltipStyle = new TooltipStyle()
                {
                    FontSize = 10
                };
                RangeNavigator.RightTooltipStyle = new TooltipStyle()
                {
                    FontSize = 10
                };
            }
        }

        void nac_RangeChanged(object sender, Syncfusion.RangeNavigator.XForms.RangeChangedEventArgs e)
        {
            dateTimeAxis.Minimum = e.ViewRangeStartDate;
            dateTimeAxis.Maximum = e.ViewRangeEndDate;
        }
    }

}

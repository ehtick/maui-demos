#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Maui.Base;
using Syncfusion.Maui.Charts;
namespace SampleBrowser.Maui.CartesianChart.SfCartesianChart;

    public partial class StackedAreaChart : SampleView
    {
        public StackedAreaChart()
        {
            InitializeComponent();
        }
        public override void OnAppearing()
        {
            base.OnAppearing();           
#if IOS
            if (IsCardView)
            {
                Chart.WidthRequest = 350;
                Chart.HeightRequest = 400;
                Chart.VerticalOptions = LayoutOptions.Start;
            }
#endif
            if (!IsCardView)
            {
                XAxis.Title = new ChartAxisTitle() { Text = "Year" };
                YAxis.Title = new ChartAxisTitle() { Text = "Spends" };
            }
        }

        public override void OnDisappearing()
        {
            base.OnDisappearing();
            Chart.Handler?.DisconnectHandler();
        }
    }
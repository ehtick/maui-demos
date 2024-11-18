#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Maui.Base;
using Syncfusion.Maui.Buttons;
using Syncfusion.Maui.Charts;
using MAUIPicker = Microsoft.Maui.Controls.Picker;

namespace SampleBrowser.Maui.PolarChart.SfPolarChart;

public partial class DefaultPolar : SampleView
{
    public DefaultPolar()
    {
        InitializeComponent();
    }

    public override void OnDisappearing()
    {
        base.OnDisappearing();
        Chart.Handler?.DisconnectHandler();
    }

    private void type_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (MAUIPicker)sender;
        int selectedIndex = picker.SelectedIndex;
        if (selectedIndex == 0)
        {
            area1.IsVisible = area2.IsVisible = area3.IsVisible = true;
            line1.IsVisible = line2.IsVisible = line3.IsVisible = false;

        }
        else if (selectedIndex == 1)
        {
            line1.IsVisible = line2.IsVisible = line3.IsVisible = true;
            area1.IsVisible = area2.IsVisible = area3.IsVisible = false;
        }
    }

    private void Angle_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (MAUIPicker)sender;
        int selectedIndex = picker.SelectedIndex;
        if (selectedIndex == 0)
        {
            Chart.StartAngle = ChartPolarAngle.Rotate0;
        }
        else if (selectedIndex == 1)
        {
            Chart.StartAngle = ChartPolarAngle.Rotate90;
        }
        else if (selectedIndex == 2)
        {
            Chart.StartAngle = ChartPolarAngle.Rotate180;
        }
        else
        {
            Chart.StartAngle = ChartPolarAngle.Rotate270;
        }
    }

    private void switch_StateChanged(object sender, SwitchStateChangedEventArgs e)
    {
        var state = e.NewValue;
        if (state == true)
        {
            area1.IsClosed = area2.IsClosed = area3.IsClosed = true;
            line1.IsClosed = line2.IsClosed = line3.IsClosed = true;
        }
        else
        {
            area1.IsClosed = area2.IsClosed = area3.IsClosed = false;
            line1.IsClosed = line2.IsClosed = line3.IsClosed = false;
        }
    }
}
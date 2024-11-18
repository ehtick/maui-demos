#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Maui.Base;
using SampleBrowser.Maui.Inputs.Samples.NumericUpDown.NumericUpDownGettingStarted.ViewModel;

namespace SampleBrowser.Maui.Inputs.NumericUpDown;

public partial class NumericUpDownGettingStartedMobile : SampleView
{
	public NumericUpDownGettingStartedMobile()
	{
		InitializeComponent();
        GettingStartedViewModel vm = new GettingStartedViewModel();
        listView.BindingContext = vm;
    }
}
    

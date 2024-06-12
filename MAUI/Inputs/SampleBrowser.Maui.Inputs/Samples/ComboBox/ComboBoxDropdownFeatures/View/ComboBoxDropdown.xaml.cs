#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Maui.Base;

namespace SampleBrowser.Maui.Inputs.SfComboBox;

public partial class ComboBoxDropdown : SampleView
{
	public ComboBoxDropdown()
	{
		InitializeComponent();
#if ANDROID || IOS
        ComboBoxDropdownMobile mobile = new ComboBoxDropdownMobile();
        this.Content = mobile.Content;
        this.OptionView = mobile.OptionView;
#else
        ComboBoxDropdownDesktop desktop = new ComboBoxDropdownDesktop();
        this.Content = desktop.Content;
        this.OptionView = desktop.OptionView;
#endif
    }
}
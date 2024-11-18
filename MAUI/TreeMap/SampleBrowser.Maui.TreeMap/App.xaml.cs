#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace SampleBrowser.Maui.TreeMap
{
    using System.Reflection;

    public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
		}
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var appInfo = typeof(App).GetTypeInfo().Assembly;
            SampleBrowser.Maui.Base.BaseConfig.IsIndividualSB = true;
            return new Window(SampleBrowser.Maui.Base.BaseConfig.MainPageInit(appInfo));
        }
    }
}
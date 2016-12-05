using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AppMetricaXamarin.Droid
{
	[Activity(Label = "AppMetricaXamarin.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize, ScreenOrientation = ScreenOrientation.Portrait)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
			global::CarouselView.FormsPlugin.Android.CarouselViewRenderer.Init();
			global::OxyPlot.Xamarin.Forms.Platform.Android.PlotViewRenderer.Init();

			YandexMetricaAndroid.YandexMetricaImplementation.Activate(this, ConfigProvider.Config(), Application);

			LoadApplication(new App());
		}
	}
}

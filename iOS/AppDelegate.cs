using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace AppMetricaXamarin.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			global::CarouselView.FormsPlugin.iOS.CarouselViewRenderer.Init();

			YandexMetricaIOS.YandexMetricaImplementation.Activate(ConfigProvider.Config());

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}

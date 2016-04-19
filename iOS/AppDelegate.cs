using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Snppts.Foodies.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes()
                {
                    Font = UIFont.FromName("Ubuntu-Medium", 20)
                });

            return base.FinishedLaunching(app, options);
        }
    }
}


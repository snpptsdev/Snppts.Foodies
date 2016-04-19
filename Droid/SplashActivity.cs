
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.PM;

namespace Snppts.Foodies.Droid
{
    [Activity(Label = "Snppts", Theme = "@style/Theme.Splash", Icon = "@drawable/ic_launcher", MainLauncher = true, NoHistory = true, ConfigurationChanges = ConfigChanges.ScreenSize)]      
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            StartActivity(typeof(MainActivity));
        }
    }
}


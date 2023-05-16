using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CompEat_CuppyBreak_Initial
{
    [Activity(Label = "SplashActivity", Icon = "@drawable/splashscreen", Theme = "@style/Theme.Splash", MainLauncher = false)]
    class splashscreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Thread.Sleep(3000);
            Finish();
        }
    }
}
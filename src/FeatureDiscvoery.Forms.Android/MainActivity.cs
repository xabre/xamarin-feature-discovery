using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Support.V7.Widget;
using Android.OS;

namespace Plugin.FeatureDiscovery.Forms.Android
{
    [Activity(Label = "Plugin.Mfd", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static MainActivity Instance { get; private set; }

        public IMenu Menu { get; private set; }
        public Toolbar Toolbar { get; private set; }

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            Instance = this;
            Toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            Menu = menu;
            return base.OnCreateOptionsMenu(menu);

        }

       
    }
}


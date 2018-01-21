using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace PlaySpace.Droid
{
    [Activity(Label = "PlaySpace", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            
            base.OnCreate(bundle);

            
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            SetContentView(TabLayoutResource);

            Button playSpacesButton = FindViewById<Button>(Resource.Id.playSpaces);
            Button listenAmbientButton = FindViewById<Button>(Resource.Id.buttonListenAmbient);
            Button exploreButton = FindViewById<Button>(Resource.Id.buttonExplore);

            playSpacesButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(PlaySpaces));
                StartActivity(intent);
            };

            listenAmbientButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(ListenAmbient));
                StartActivity(intent);
            };

            exploreButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(Explore));
                StartActivity(intent);
            };
        }
    }
}


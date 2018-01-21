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

namespace PlaySpace.Droid
{
    [Activity(Label = "ListenAmbient")]
    public class ListenAmbient : Activity
    {
        List<string> songs = new List<string>();


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            songs.Add("aiojoijoi");
            // Create your application here

            ListView list = FindViewById<ListView>(Resource.Id.songList);
            //list.set
            //list.set

            SetContentView(Resource.Layout.ListenAmbient);
        }
    }
}
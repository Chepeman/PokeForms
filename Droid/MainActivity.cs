using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using ImageCircle.Forms.Plugin.Droid;

namespace PokeForms.Droid
{
	[Activity (Label = "PokeForms.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			ImageCircleRenderer.Init();
			global::Xamarin.Forms.Forms.Init (this, bundle);
			FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
			LoadApplication (new App ());
		}
	}
}


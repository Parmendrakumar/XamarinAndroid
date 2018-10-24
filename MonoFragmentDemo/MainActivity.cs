using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MonoFragmentDemo
{
	[Activity (Label = "MonoFragmentDemo", MainLauncher = true)]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);


            var newFragment = new FragmentMain ();
			var ft = FragmentManager.BeginTransaction ();
			ft.Add (Resource.Id.main_FragmentContainerMain, newFragment);
			ft.Commit ();
		}
	}
}



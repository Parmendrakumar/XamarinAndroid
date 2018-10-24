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

namespace MonoFragmentDemo
{
	internal class FragmentShow : Fragment
	{
		List<FragmentModel> _lstFragmentDemo = new List<FragmentModel> ();

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			_lstFragmentDemo.Add (new FragmentModel () {
				 Name = "BarCode", Desigination = "SNOP1234G"
			});

			_lstFragmentDemo.Add (new FragmentModel () {
				Name = "Height", Desigination = "23"
			});

			_lstFragmentDemo.Add (new FragmentModel () {
				Name = "Width", Desigination = "33"
			});

			_lstFragmentDemo.Add (new FragmentModel () {
				Name = "Depth", Desigination = "66"
			});
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.FragmentShow, container, false);
			var listView = view.FindViewById<ListView>(Resource.Id.fr_ListView1);
			listView.Adapter = new ListVwAdapter (this.Activity, _lstFragmentDemo);
			return view;
		}
	}
}


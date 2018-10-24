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
using MonoFragmentDemo;

namespace MonoFragmentDemo
{
	internal class FragmentMain : Fragment, View.IOnClickListener
	{
		

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			// Create your fragment here

		}



		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{

            var view = inflater.Inflate(Resource.Layout.FragmentMain, container, false);
         
            var nextButton = view.FindViewById<Button>(Resource.Id.fl_Next);
            var showButton = view.FindViewById<Button>(Resource.Id.fl_Show);

            if (nextButton != null)
                nextButton.SetOnClickListener(this);

            showButton.Click += ShowButton_Click;

            //if (showButton != null)
            //{
               
            //}
               // showButton.SetOnClickListener(this);

            return view;

          //  return inflater.Inflate(Resource.Layout.FragmentRight, null, false);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            var trans = FragmentManager.BeginTransaction();
            //  trans.Replace(Resource.Id.main_FragmentContainerLeft, new EnterPackageFragment(), "EnterPackageFragment");
            trans.Replace(Resource.Id.main_FragmentContainerMain, new FragmentShow(), "FragmentShow");
            trans.AddToBackStack(null);
            trans.Commit();
        }

        #region IOnClickListener implementation

        void View.IOnClickListener.OnClick (View view)
		{
            //SetInformationOnText (textDesg, textDesc);

            //var newFragment = new FragmentRight();
            //var ft = FragmentManager.BeginTransaction();
            //ft.Add(Resource.Id.main_FragmentContainerRight, newFragment);
            //ft.Commit();

            var trans = FragmentManager.BeginTransaction();
            trans.Replace(Resource.Id.main_FragmentContainerMain, new EnterPackageFragment(), "EnterPackageFragment");
           // trans.Replace(Resource.Id.main_FragmentContainerLeft, new FragmentRight(), "FragmentRight");
            trans.AddToBackStack(null);
            trans.Commit();
        }

		#endregion
	}
}


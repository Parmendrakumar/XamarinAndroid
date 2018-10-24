using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace MonoFragmentDemo
{
    public class EnterPackageFragment : Fragment, View.IOnClickListener
    {
        EditText barcode;
        EditText height;
        EditText width;
        EditText depth;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            // var view = inflater.Inflate(Resource.Layout.EnterPackageFragment, container, false);
            View view = inflater.Inflate(Resource.Layout.EnterPackageFragment, null);
            barcode = view.FindViewById<EditText>(Resource.Id.txtBarcode);
            height = view.FindViewById<EditText>(Resource.Id.txtHeight);
            width = view.FindViewById<EditText>(Resource.Id.txtWidth);
            depth = view.FindViewById<EditText>(Resource.Id.txtDepth);
            var save = view.FindViewById<Button>(Resource.Id.fl_Save);

            if (save != null)
                save.SetOnClickListener(this);

            // save.Click += Save_Click;

            // return base.OnCreateView(inflater, container, savedInstanceState);
            //View view = inflater.Inflate(Resource.Layout.map_layout, null);
            return view;
        }

       
        void clear()
        {
            barcode.Text = "";
            height.Text = "";
            width.Text = "";
            depth.Text = "";
        }

        public void OnClick(View v)
        {
            try
            {
                string dpPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Person.db3");
                var db = new SQLite.SQLiteConnection(dpPath);
                db.CreateTable<Persontable>();
                Persontable tbl = new Persontable();
                tbl.Barcode = barcode.Text;
                tbl.Height = height.Text;
                tbl.Width = width.Text;
                tbl.Depth = depth.Text;
                db.Insert(tbl);
                clear();

                Toast.MakeText(Context, "Data has been submitted successfully..!", ToastLength.Short).Show();
                

            }
            catch (Exception ex)
            {
                // Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
        }

       
    }
}
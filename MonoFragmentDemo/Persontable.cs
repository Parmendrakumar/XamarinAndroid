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
using SQLite;

namespace MonoFragmentDemo
{
    class Persontable
    {
        [PrimaryKey, AutoIncrement, Column("_Id")]
        public int id
        {
            get;
            set;
        } // AutoIncrement and set primarykey  

        public string Barcode
        {
            get;
            set;
        }
        public string Height
        {
            get;
            set;
        }
        public string Width
        {
            get;
            set;
        }
        public string Depth
        {
            get;
            set;
        }

    }
}
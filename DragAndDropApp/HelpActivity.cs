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

namespace DragAndDropApp
{
    [Activity(Label = "HelpActivity")]
    public class HelpActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_Help);

            // Create your application here

            var BackButton = FindViewById(Resource.Id.BackButton) as Button;

            BackButton.Click += delegate
            {
                Finish();
            };

            var info = FindViewById(Resource.Id.TextInfo) as TextView;
            info.Text = "To use this program please go back and hold the items for more then 10 seconds before trying to drag them around";
        }
       
    }
}
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
    [Activity(Label = "FinishActivity")]
    public class FinishActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_finish);
            var BackButton = FindViewById(Resource.Id.BackButton) as Button;
            BackButton.Click += delegate
            {
                Finish();
            };
        }
    }
}
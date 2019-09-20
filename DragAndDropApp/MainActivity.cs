using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Views;
using Android.Graphics;
using System.Collections.Generic;
using AlertDialog = Android.Support.V7.App.AlertDialog;
using Android.Content;

namespace DragAndDropApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        List<int> items;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var buttonHelp = FindViewById(Resource.Id.HelpButton) as Button;

            buttonHelp.Click += delegate
            {
                StartActivity(typeof(HelpActivity));
            };

            var list = FindViewById<DraggableListView>(Resource.Id.draggableListView1);

            items = new List<int> {
              1,
              5,
              4,
              2,
              3,
            };
            list.Adapter = new DraggableListAdapter(this, items);

        }

        /**
         * If the list is sorted view finish page 
         */
        public void FinishMenu()
        {
           // var intent = new Intent(this, typeof(finishActivity));
            //StartActivity(intent);
           StartActivity(typeof(FinishActivity));
        }

    }
   
 }
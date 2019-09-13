using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Views;
using Android.Graphics;
using System.Collections.Generic;

namespace DragAndDropApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        List<string> items;

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

            items = new List<string> {
                "Star Wars",
                "Star Trek",
                "Harry Potter",
                "DC",
                "Marvel",
                "Doctor Who",

            };
            list.Adapter = new DraggableListAdapter(this, items);
        }
    }


   
 }
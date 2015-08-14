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

namespace Automata_Teacher_3
{
    [Activity(Label = "What is an automaton?", ParentActivity = typeof(CategoriesActivity))]
    public class Topic1Activity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            SetContentView(Resource.Layout.Topic1Layout);

            Button quiz1Button = FindViewById<Button>(Resource.Id.Quiz1Button);

            quiz1Button.Click += delegate {
                StartActivity(typeof(Quiz1Activity));
            };
        }
    }
}
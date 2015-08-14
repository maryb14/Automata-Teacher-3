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
    [Activity(Label = "Determinism and non-determinism", ParentActivity = typeof(CategoriesActivity))]
    public class Topic5Activity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            SetContentView(Resource.Layout.Topic5Layout);

            Button quiz5Button = FindViewById<Button>(Resource.Id.Quiz5Button);

            quiz5Button.Click += delegate {
                StartActivity(typeof(Quiz5Activity));
            };
        }
    }
}
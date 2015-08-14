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
    [Activity(Label = "Languages and automata", ParentActivity = typeof(CategoriesActivity))]
    public class Topic2Activity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            SetContentView(Resource.Layout.Topic2Layout);


            Button quiz2Button = FindViewById<Button>(Resource.Id.Quiz2Button);

            quiz2Button.Click += delegate {
                StartActivity(typeof(Quiz2Activity));
            };
        }
    }
}
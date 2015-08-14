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
    [Activity(Label = "Generative grammars for the four languages", ParentActivity = typeof(CategoriesActivity))]
    public class Topic3Activity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            SetContentView(Resource.Layout.Topic3Layout);

            Button quiz3Button = FindViewById<Button>(Resource.Id.Quiz3Button);

            quiz3Button.Click += delegate {
                StartActivity(typeof(Quiz3Activity));
            };
        }
    }
}
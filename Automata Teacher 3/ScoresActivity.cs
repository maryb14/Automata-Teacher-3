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
    [Activity(Label = "ScoresActivity", ParentActivity = typeof(MainActivity))]
    public class ScoresActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            SetContentView(Resource.Layout.ScoresLayout);

            ISharedPreferences prefs = Application.Context.GetSharedPreferences("Results", FileCreationMode.Private);
            int score1p = prefs.GetInt("score1", 0);

            TextView result1 = FindViewById<TextView>(Resource.Id.Result1);
            result1.Text = "Your best score in 'Quiz - What is an automaton?' is " + score1p + " out of 5";

            int score2p = prefs.GetInt("score2", 0);

            TextView result2 = FindViewById<TextView>(Resource.Id.Result2);
            result2.Text = "Your best score in 'Quiz - Languages and automata' is " + score2p + " out of 5";

            int score3p = prefs.GetInt("score3", 0);

            TextView result3 = FindViewById<TextView>(Resource.Id.Result3);
            result3.Text = "Your best score in 'Quiz - Generative grammars for the four languages' is " + score3p + " out of 4";

            int score5p = prefs.GetInt("score5", 0);

            TextView result5 = FindViewById<TextView>(Resource.Id.Result5);
            result5.Text = "Your best score in 'Quiz - Determinism and non-determinism' is " + score5p + " out of 4";

        }
    }
}
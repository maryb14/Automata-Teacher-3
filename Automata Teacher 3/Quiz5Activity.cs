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
    [Activity(Label = "Quiz - Determinism and non-determinism")]
    public class Quiz5Activity : Activity
    {
        int score5 = 0;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            SetContentView(Resource.Layout.Quiz5Layout);

            Button submitButton1 = FindViewById<Button>(Resource.Id.SubmitButton1);
            RadioButton answer12 = FindViewById<RadioButton>(Resource.Id.Answer12);
            RadioButton answer23 = FindViewById<RadioButton>(Resource.Id.Answer23);
            RadioButton answer32 = FindViewById<RadioButton>(Resource.Id.Answer32);
            RadioButton answer42 = FindViewById<RadioButton>(Resource.Id.Answer42);

            submitButton1.Click += delegate
            {
                if (answer12.Checked == true) score5++;
                if (answer23.Checked == true) score5++;
                if (answer32.Checked == true) score5++;
                if (answer42.Checked == true) score5++;
                ISharedPreferences prefs = Application.Context.GetSharedPreferences("Results", FileCreationMode.Private);
                int score5p = prefs.GetInt("score5", 0);
                if (score5p < score5)
                {
                    ISharedPreferencesEditor editor = prefs.Edit();
                    editor.PutInt("score5", score5);
                    editor.Apply();
                }
                TextView showingResult1 = FindViewById<TextView>(Resource.Id.ShowingResult1);
                showingResult1.Text = "You scored " + score5 + " out of 4";
                score5 = 0;
            };
        }
    }
}
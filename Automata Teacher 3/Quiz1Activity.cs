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
    [Activity(Label = "Quiz - What is an automaton?")]
    public class Quiz1Activity : Activity
    {   
        int score1 = 0;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            SetContentView(Resource.Layout.Quiz1Layout);

            Button submitButton1 = FindViewById<Button>(Resource.Id.SubmitButton1);
            RadioButton answer12 = FindViewById<RadioButton>(Resource.Id.Answer12);
            RadioButton answer22 = FindViewById<RadioButton>(Resource.Id.Answer22);
            RadioButton answer31 = FindViewById<RadioButton>(Resource.Id.Answer31);
            RadioButton answer43 = FindViewById<RadioButton>(Resource.Id.Answer43);
            RadioButton answer53 = FindViewById<RadioButton>(Resource.Id.Answer53);


            submitButton1.Click += delegate
            {
                if (answer12.Checked == true) score1++;
                if (answer22.Checked == true) score1++;
                if (answer31.Checked == true) score1++;
                if (answer43.Checked == true) score1++;
                if (answer53.Checked == true) score1++;
                ISharedPreferences prefs = Application.Context.GetSharedPreferences("Results", FileCreationMode.Private);
                int score1p = prefs.GetInt("score1", 0);
                if (score1p < score1)
                {
                    ISharedPreferencesEditor editor = prefs.Edit();
                    editor.PutInt("score1", score1);
                    editor.Apply();
                }
                TextView showingResult1 = FindViewById<TextView>(Resource.Id.ShowingResult1);
                showingResult1.Text = "You scored " + score1 + " out of 5";
                score1 = 0;
            };
        }
    }
}
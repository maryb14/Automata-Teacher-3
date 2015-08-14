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
    [Activity(Label = "Quiz - Generative grammars for the four languages")]
    public class Quiz3Activity : Activity
    {
        int score3= 0;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            SetContentView(Resource.Layout.Quiz3Layout);

            Button submitButton1 = FindViewById<Button>(Resource.Id.SubmitButton1);
            RadioButton answer11 = FindViewById<RadioButton>(Resource.Id.Answer11);
            RadioButton answer21 = FindViewById<RadioButton>(Resource.Id.Answer21);
            RadioButton answer32 = FindViewById<RadioButton>(Resource.Id.Answer32);
            RadioButton answer41 = FindViewById<RadioButton>(Resource.Id.Answer41);

            submitButton1.Click += delegate
            {
                if (answer11.Checked == true) score3++;
                if (answer21.Checked == true) score3++;
                if (answer32.Checked == true) score3++;
                if (answer41.Checked == true) score3++;
                ISharedPreferences prefs = Application.Context.GetSharedPreferences("Results", FileCreationMode.Private);
                int score3p = prefs.GetInt("score3", 0);
                if (score3p < score3)
                {
                    ISharedPreferencesEditor editor = prefs.Edit();
                    editor.PutInt("score3", score3);
                    editor.Apply();
                }
                TextView showingResult1 = FindViewById<TextView>(Resource.Id.ShowingResult1);
                showingResult1.Text = "You scored " + score3 + " out of 4";
                score3 = 0;
            };
        }
    }
}
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
    [Activity(Label = "Quiz - Languages and automata")]
    public class Quiz2Activity : Activity
    {
        int score2 = 0;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            SetContentView(Resource.Layout.Quiz2Layout);

            Button submitButton2 = FindViewById<Button>(Resource.Id.SubmitButton2);
            RadioButton answer13 = FindViewById<RadioButton>(Resource.Id.Answer13);
            RadioButton answer21 = FindViewById<RadioButton>(Resource.Id.Answer21);
            RadioButton answer32 = FindViewById<RadioButton>(Resource.Id.Answer32);
            RadioButton answer41 = FindViewById<RadioButton>(Resource.Id.Answer41);
            RadioButton answer51 = FindViewById<RadioButton>(Resource.Id.Answer51);


            submitButton2.Click += delegate
            {
                if (answer13.Checked == true) score2++;
                if (answer21.Checked == true) score2++;
                if (answer32.Checked == true) score2++;
                if (answer41.Checked == true) score2++;
                if (answer51.Checked == true) score2++;
                ISharedPreferences prefs = Application.Context.GetSharedPreferences("Results", FileCreationMode.Private);
                int score2p = prefs.GetInt("score2", 0);
                if (score2p < score2)
                {
                    ISharedPreferencesEditor editor = prefs.Edit();
                    editor.PutInt("score2", score2);
                    editor.Apply();
                }
                TextView showingResult1 = FindViewById<TextView>(Resource.Id.ShowingResult1);
                showingResult1.Text = "You scored " + score2 + " out of 5";
                score2 = 0;
            };
        }
    }
}
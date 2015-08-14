using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Automata_Teacher_3
{
    [Activity(Label = "Automata Teacher", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {   

            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            Button topicsButton = FindViewById<Button>(Resource.Id.TopicsButton);

            Button quizesButton = FindViewById<Button>(Resource.Id.QuizesButton);

            Button scoresButton = FindViewById<Button>(Resource.Id.ScoresButton);

            topicsButton.Click += delegate {
                StartActivity(typeof(CategoriesActivity));
            };

            quizesButton.Click += delegate
            {
                StartActivity(typeof(QuizesActivity));
            };

            scoresButton.Click += delegate
            {
                StartActivity(typeof(ScoresActivity));
            };
        }
    }
}


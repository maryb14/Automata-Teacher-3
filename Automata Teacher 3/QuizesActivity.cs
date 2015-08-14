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
    [Activity(Label = "Quizes", ParentActivity = typeof(MainActivity))]
    public class QuizesActivity : Activity
    {
        private List<string> list_items1;

        private ListView quizesList;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            SetContentView(Resource.Layout.QuizesLayout);

            list_items1 = new List<string>();

            list_items1.Add("Quiz - What is an automaton?");

            list_items1.Add("Quiz - Languages and automata");

            list_items1.Add("Quiz - Generative grammars for the four languages");

            list_items1.Add("Quiz - Determinism and non-determinism");

            quizesList = FindViewById<ListView>(Resource.Id.QuizesList);

            MyListViewAdapter adapter1 = new MyListViewAdapter(this, list_items1);

            quizesList.Adapter = adapter1;

            quizesList.ItemClick += quizesList_ItemClick;

        }

        void quizesList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            string selected_categ = list_items1[e.Position];
            if (selected_categ == "Quiz - What is an automaton?")
            {
                StartActivity(typeof(Quiz1Activity));
            }
            else if (selected_categ == "Quiz - Languages and automata")
            {
                StartActivity(typeof(Quiz2Activity));
            }
            else if (selected_categ == "Quiz - Generative grammars for the four languages")
            {
                StartActivity(typeof(Quiz3Activity));
            }
            else
            {
                StartActivity(typeof(Quiz5Activity));
            }
        }
    }
}
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
    [Activity(Label = "Topics", ParentActivity = typeof(MainActivity))]
    public class CategoriesActivity : Activity
    {
        private List<string> list_items;

        private ListView categoriesList;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.CategoriesLayout);

            list_items = new List<string>();

            list_items.Add("What is an automaton?");

            list_items.Add("Languages and automata");

            list_items.Add("Generative grammars for the four languages");

            list_items.Add("The pumping lemma");

            list_items.Add("Determinism and non-determinism");

            categoriesList = FindViewById<ListView>(Resource.Id.CategoriesList);

            MyListViewAdapter adapter = new MyListViewAdapter(this, list_items);

            categoriesList.Adapter = adapter;

            categoriesList.ItemClick += categoriesList_ItemClick;
         }

        void categoriesList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            string selected_categ = list_items[e.Position];
            if(selected_categ == "What is an automaton?")
            {
                StartActivity(typeof(Topic1Activity));
            }
            else if(selected_categ == "Languages and automata")
            {
                StartActivity(typeof(Topic2Activity));
            }
            else if (selected_categ == "Generative grammars for the four languages")
            {
                StartActivity(typeof(Topic3Activity));
            }
            else if (selected_categ == "The pumping lemma")
            {
                StartActivity(typeof(Topic4Activity));
            }
            else
            {
                StartActivity(typeof(Topic5Activity));
            }
        }
    }
}
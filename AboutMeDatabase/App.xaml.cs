using System;
using System.Collections.Generic;
using AboutMeDatabase.Data;
using AboutMeDatabase.Models;
using Xamarin.Forms;


namespace AboutMeDatabase
{
    public partial class App : Application
    {
        static PersonalItemDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static PersonalItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new PersonalItemDatabase(); 
                    prefillDatabase();

                }
                return database;
            }
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        static void prefillDatabase()
        {
            database.ClearAllAsync();
            List<PersonalItem> all = new List<PersonalItem>();
                all.Add(new PersonalItem() { TheFact = "Notebook", ShortFact = "Favorite movie", Image = "notebook.jpg" });
                all.Add(new PersonalItem() { TheFact = "Hiking", ShortFact = "hobby", Image = "mountain.jpg" });
                all.Add(new PersonalItem() { TheFact = "Green", ShortFact = "Favorite color", Image = "green.jpg" });
                all.Add(new PersonalItem() { TheFact = "Korean Food", ShortFact = "Favorite food", Image = "food.jpg" });
                all.Add(new PersonalItem() { TheFact = "BTS", ShortFact = "Favorite idol", Image = "bts.jpg" });
            
            database.InsertList(all);

        }
    }
}

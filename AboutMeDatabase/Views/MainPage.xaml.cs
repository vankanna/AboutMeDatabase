using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AboutMeDatabase.Models;
using Xamarin.Forms;

namespace AboutMeDatabase
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            PersonalItem fact = (PersonalItem)e.SelectedItem;
            DisplayAlert("The Fact", fact.TheFact, "Ok");
        }

    }
}

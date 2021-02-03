using core.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace presentation.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SavedGameListPage : ContentPage
    {

        public SavedGameListPage()
        {
            InitializeComponent();

            SaveButton.IsVisible = false;
        }

        public SavedGameListPage(bool saveGameMode)
        {
            InitializeComponent();

            SaveButton.IsVisible = saveGameMode;
        }
        
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            sessionList.ItemsSource = await SessionController.findAllAsync();
        
        }

        void OnOpenButtonClicked(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();
        }
        
        void OnSaveButtonClicked(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();
        }

        void OnCancelButtonClicked(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();
        }

    }

}
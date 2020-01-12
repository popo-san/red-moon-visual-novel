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
    public partial class GamePage : ContentPage
    {

        public GamePage()
        {
            InitializeComponent();
        }

        void OnMenuButtonClicked(object sender, EventArgs args)
        {
            MenuPanel.FadeTo(1, 256);
            MenuPanel.InputTransparent = false;
        }

        void OnPageClicked(object sender, EventArgs args)
        {
            MenuPanel.FadeTo(0, 256);
            MenuPanel.InputTransparent = true;
        }

        void OnSaveButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new SavedGameListPage(true));
        }

        void OnExitButtonClicked(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();
        }

    }

}
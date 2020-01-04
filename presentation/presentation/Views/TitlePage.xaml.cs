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
    public partial class TitlePage : ContentPage
    {

        public TitlePage()
        {
            InitializeComponent();
        }

        async void OnNewGameButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new NewGamePage());
        }

        async void OnOpenGameButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new SavedGameListPage());
        }

        async void OnAboutButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new AboutPage());
        }

    }

}
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

        void OnNewGameButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new NewGamePage());
        }

        void OnOpenGameButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new SavedGameListPage());
        }

        void OnAboutButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new AboutPage());
        }

    }

}
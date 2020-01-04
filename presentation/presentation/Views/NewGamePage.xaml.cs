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
    public partial class NewGamePage : ContentPage
    {

        public NewGamePage()
        {
            InitializeComponent();
        }

        async void OnOKButtonClicked(object sender, EventArgs args)
        {

            await Navigation.PopModalAsync();

            await Navigation.PushModalAsync(new GamePage());

        }

        async void OnCancelButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

    }

}
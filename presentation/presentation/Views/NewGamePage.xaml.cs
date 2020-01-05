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

         void OnOKButtonClicked(object sender, EventArgs args)
        {

             Navigation.PopModalAsync();

             Navigation.PushModalAsync(new GamePage());

        }

        void OnCancelButtonClicked(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();
        }

    }

}
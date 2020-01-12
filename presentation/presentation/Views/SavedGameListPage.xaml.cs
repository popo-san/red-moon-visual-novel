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

        public SavedGameListPage(bool saveGameMode)
        {
            InitializeComponent();
        }

        public SavedGameListPage()
        {
            InitializeComponent();
        }

        void OnCancelButtonClicked(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();
        }

    }

}
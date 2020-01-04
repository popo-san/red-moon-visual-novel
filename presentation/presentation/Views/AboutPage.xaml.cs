using presentation.Resources;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace presentation.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {

        async void OnProjectRepositoryButtonClicked(object sender, EventArgs args)
        {
            await Browser.OpenAsync(PageTexts.ProjectRepositoryUrl, BrowserLaunchMode.SystemPreferred);
        }

        async void OnProjectLicenseButtonClicked(object sender, EventArgs args)
        {
            await Browser.OpenAsync(PageTexts.ProjectLicenseUrl, BrowserLaunchMode.SystemPreferred);
        }

        async void OnCloseButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }

        public AboutPage()
        {
            InitializeComponent();
        }

    }

}
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

        void OnProjectRepositoryButtonClicked(object sender, EventArgs args)
        {
             Browser.OpenAsync(PageTexts.ProjectRepositoryUrl, BrowserLaunchMode.SystemPreferred);
        }

       void OnProjectLicenseButtonClicked(object sender, EventArgs args)
        {
             Browser.OpenAsync(PageTexts.ProjectLicenseUrl, BrowserLaunchMode.SystemPreferred);
        }

        void OnCloseButtonClicked(object sender, EventArgs args)
        {
             Navigation.PopModalAsync();
        }

        public AboutPage()
        {
            InitializeComponent();
        }

    }

}
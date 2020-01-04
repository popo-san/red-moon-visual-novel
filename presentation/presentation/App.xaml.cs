using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace presentation
{

    public partial class App : Application
    {

        const string androidKey = "9eb6f878-ea85-49d3-bbc0-cc69d4b9f20c";
        const string uwpKey = "";
        const string iosKey = "";

        public App()
        {

            InitializeComponent();

            MainPage = new MainPage();
        
        }

        protected override void OnStart()
        {

            // NOTE jfp See the following links for documentation.
            // https://docs.microsoft.com/en-us/appcenter/sdk/getting-started/Xamarin
            // https://docs.microsoft.com/en-us/appcenter/sdk/crashes/xamarin#generate-a-test-crash

            AppCenter.LogLevel = LogLevel.Verbose;

            AppCenter.Start($"android={androidKey};uwp={uwpKey};ios={iosKey};",
                typeof(Analytics), typeof(Crashes));

            //Crashes.GenerateTestCrash();

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }

    }

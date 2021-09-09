using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace helloxamarin
{
    public partial class App : Application
    {
        //private static readonly Uri _TARGET_URL = new Uri("https://wikipedia.org");
        private static readonly Uri _TARGET_URL = new Uri("https://durehjournal.com");
        private static readonly BrowserLaunchOptions _BROWSER_OPTIONS = new BrowserLaunchOptions
        {
            LaunchMode = BrowserLaunchMode.External, // .SystemPreferred will launch within the app which may be preferable?
            TitleMode = BrowserTitleMode.Default
        };

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
        protected override void OnStart()
        {
            try
            {
                Browser.OpenAsync(_TARGET_URL, _BROWSER_OPTIONS);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace.ToString());
                // An unexpected error occured. No browser may be installed on the device.
            }
            finally
            {
                Quit(); // this does nothing
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace helloxamarin.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private static readonly Uri _TARGET_URL = new Uri("https://durehjournal.com");
        private static readonly BrowserLaunchOptions _BROWSER_OPTIONS = new BrowserLaunchOptions
        {
            LaunchMode = BrowserLaunchMode.External, // .SystemPreferred will launch within the app which may be preferable?
            TitleMode = BrowserTitleMode.Default
        };

        public AboutViewModel()
        {
            Title = "About";
            // OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            OpenWebCommand = new Command(async () =>
            // This method returns after the browser was launched and not necessarily closed by the user.
            // The bool result indicates whether the launching was successful or not.
            {
                try
                {
                    await Browser.OpenAsync(_TARGET_URL, _BROWSER_OPTIONS);
                }
                catch (Exception e)
                {
                    //e.StackTrace.ToString();
                    // An unexpected error occured. No browser may be installed on the device.
                }
            }
            );
        }

        public ICommand OpenWebCommand { get; }

    }
}
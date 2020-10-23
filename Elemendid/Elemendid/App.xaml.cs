using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Elemendid.Services;
using Elemendid.Views;

namespace Elemendid
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }

    internal class Navigation : Page
    {
        private MainPage mainPage;

        public Navigation(MainPage mainPage)
        {
            this.mainPage = mainPage;
        }
    }
}

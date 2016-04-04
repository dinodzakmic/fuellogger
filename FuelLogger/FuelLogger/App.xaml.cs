using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuelLogger.ViewModel;
using Xamarin.Forms;

namespace FuelLogger
{
    public partial class App : Application
    {
        private NavigationPage navigationPage;
        private static ViewModelLocator _locator;

        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }
        public App()
        {
            // The root page of your application
            MainPage = new Menu();
            navigationPage = (NavigationPage)((MasterDetailPage)MainPage).Detail;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using FuelLogger.ViewModel;
using PCLStorage;
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

        protected override async void OnStart()
        {
            //var rootFolder = FileSystem.Current.LocalStorage;
            //var cacheFolder = rootFolder.GetFolderAsync("FuelLogger").Result;
            //IFile file = await cacheFolder.GetFileAsync("pictureFile.txt");
            //if (file != null)
            //{
            //    var content = file.ReadAllTextAsync().Result;
            //    if (content != "")
            //    {
            //        var exist = FileSystem.Current.GetFileFromPathAsync(content);
            //        if (exist != null)
            //        {
            //            var stringReader = new StringReader(content);
            //            var text = stringReader.ReadToEnd();
            //            App.Locator.User.ProfilePicture = text;
            //        }
            //    }
            //    else App.Locator.User.ProfilePicture = "car.jpg";
            //}

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

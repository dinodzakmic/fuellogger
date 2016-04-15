using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelLogger.Pages;
using PCLStorage;
using Plugin.Media;
using Xamarin.Forms;

namespace FuelLogger
{
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            var detailPage = new NavigationPage(new Dashboard() {Title = "FuelLogger"});
            Detail = detailPage;
            BindingContext = App.Locator.User;
        }



        private void DashboardTapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Dashboard());
            IsPresented = false;
        }

        private void CalculatorTapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Calculator());
            IsPresented = false;
        }

        private  void MapTapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Mapica());
            IsPresented = false;

        }


        private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            if (CrossMedia.Current.IsPickPhotoSupported)
            {
                Plugin.Media.Abstractions.MediaFile file = await CrossMedia.Current.PickPhotoAsync();
                if (file != null)
                {
                    var streamReader = new StreamReader(file.GetStream());
                    var memStream = new MemoryStream();
                    streamReader.BaseStream.CopyTo(memStream);
                    var bytes = default(byte[]);
                    bytes = memStream.ToArray();
                    var fileName = Path.GetFileName(file.Path);
                    var type = Path.GetExtension(file.Path);
                    App.Locator.User.ProfilePicture = file.Path.ToString();
                    IFolder rootFolder = FileSystem.Current.LocalStorage;
                    IFolder folder =
                        await rootFolder.CreateFolderAsync("FuelLogger", CreationCollisionOption.OpenIfExists);
                    IFile myFile = await folder.CreateFileAsync("pictureFile.txt", CreationCollisionOption.ReplaceExisting);
                    await myFile.WriteAllTextAsync(file.Path.ToString());
                }
            }
        }

        private void CostLogsTapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AddCostLogs());
            IsPresented = false;
        }

       
    }
}

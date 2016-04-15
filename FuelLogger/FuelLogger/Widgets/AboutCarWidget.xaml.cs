using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelLogger.Pages;
using Xamarin.Forms;

namespace FuelLogger.Widgets
{
    public partial class AboutCarWidget : ContentView
    {
        public AboutCarWidget()
        {
            InitializeComponent();
            BindingContext = App.Locator.User;
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditCarInfo());
        }
    }
}

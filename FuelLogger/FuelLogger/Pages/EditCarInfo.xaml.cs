using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XLabs.Forms.Services;

namespace FuelLogger.Pages
{
    public partial class EditCarInfo : ContentPage
    {
        public string test;
        public EditCarInfo()
        {
            InitializeComponent();
            test = App.Locator.User.CarHP;
            BindingContext = App.Locator.User;
         
        }


        protected override bool OnBackButtonPressed()
        {
            App.Locator.User.CarHP = test;
            return base.OnBackButtonPressed();
        }
    }
}

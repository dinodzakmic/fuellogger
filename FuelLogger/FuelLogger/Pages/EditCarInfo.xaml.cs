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
        private string cartype;
        private string caryear;
        private string carhp;

        public EditCarInfo()
        {
            InitializeComponent();
            cartype = App.Locator.User.CarType;
            caryear = App.Locator.User.CarYear;
            carhp = App.Locator.User.CarHP;
            BindingContext = App.Locator.User;
         
        }


        protected override bool OnBackButtonPressed()
        {
            if (txtType.Text != cartype || txtHP.Text != carhp || txtYear.Text != caryear)
            {

                DisplayAlert("Alert", "Changes are not saved!", "OK");
                App.Locator.User.CarHP = carhp;
                App.Locator.User.CarType = cartype;
                App.Locator.User.CarYear = caryear;
                
            }


            return base.OnBackButtonPressed();
        }

       
    }
}

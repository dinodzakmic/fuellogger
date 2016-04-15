using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FuelLogger.Pages
{
    public partial class AddCostLogs : ContentPage
    {
        public AddCostLogs()
        {
            InitializeComponent();
            BindingContext = App.Locator.AddCost;
            productPicker.Items.Add("Service");
            productPicker.Items.Add("Fuel");
            productPicker.Items.Add("Accessories");
            productPicker.Items.Add("Parking");
            productPicker.SelectedIndex = 0;

        }

        private void ProductPicker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker) sender;
            var index = picker.SelectedIndex;
            App.Locator.AddCost.productImage ="Letter"+ productPicker.Items[index].ToString()+".png";
            App.Locator.AddCost.SelectedProduct = productPicker.Items[index];
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FuelLogger.Pages
{
    public partial class PriceCalculator : ContentPage
    {
        public PriceCalculator()
        {
            InitializeComponent();
            BindingContext = App.Locator.Calculators;
        }

      
       
    }
}

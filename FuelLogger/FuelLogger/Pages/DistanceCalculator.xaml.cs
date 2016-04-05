using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FuelLogger.Pages
{
    public partial class DistanceCalculator : ContentPage
    {
        public DistanceCalculator()
        {
            InitializeComponent();
            BindingContext = App.Locator.Calculators;
        }
    }
}

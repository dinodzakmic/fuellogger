using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FuelLogger.ViewModel
{
   public class CalculatorsViewModel : MainViewModel
   {
       private string _distance;

       public string Distance
       {
           get { return _distance; }
           set
           {
               _distance = value;
               RaisePropertyChanged(()=>Distance);
           }
       }

       private string _price;

        public string Price
        {
            get { return _price; }
            set
            {
                _price = value;
                RaisePropertyChanged(() => Price);
            }
        }

        private string _efficiency;

        public string Efficiency
        {
            get { return _efficiency; }
            set
            {
                _efficiency = value;
                RaisePropertyChanged(() => Efficiency);
            }
        }

       private string _priceResult= "Price : " + "0" + " EUR";

       public string PriceResult
       {
           get { return _priceResult; }
           set
           {
               _priceResult = value;
               RaisePropertyChanged(()=>PriceResult);
           }
       }
        public ICommand ResetCommand { private set; get; }
        public ICommand CalculatePriceCommand { private set; get; }
        public CalculatorsViewModel()
       {
           ResetCommand = new Command(Reset);
           CalculatePriceCommand = new Command(CalculatePrice);
       }
       
       public void Reset()
       {
           Distance = "";
           Price = "";
           Efficiency = "";
            PriceResult = "Price : " + "0" + " EUR";
        }

       public void CalculatePrice()
       {
           var distanceInKm = double.Parse(Distance)/100;
           var value = double.Parse(Efficiency)*distanceInKm;
           PriceResult= "Price : "+(value*double.Parse(Price)).ToString()+" EUR";
           
       }
    }
}

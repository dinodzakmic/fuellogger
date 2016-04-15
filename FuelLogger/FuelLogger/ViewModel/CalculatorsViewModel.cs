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

       private string _totalPrice;

       public string TotalPrice
       {
           get { return _totalPrice;}
           set
           {
               _totalPrice = value;
               RaisePropertyChanged(()=>TotalPrice);
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

       private string _distanceResult = "Distance : " + "0" + " km";

       public string DistanceResult
       {
           get { return _distanceResult; }
           set
           {
               _distanceResult = value;
               RaisePropertyChanged(()=>DistanceResult);
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
        public ICommand CalculateDistanceCommand { private set; get; }
        public ICommand ResetDistanceCommand { private set; get; }
        public CalculatorsViewModel()
       {
           ResetCommand = new Command(Reset);
           CalculatePriceCommand = new Command(CalculatePrice);
            CalculateDistanceCommand = new Command(CalculateDistance);
            ResetDistanceCommand = new Command(ResetDistanceCalc);
       }

       public void ResetDistanceCalc()
       {
           TotalPrice = "";
           Price = "";
           Efficiency = "";
           DistanceResult = "Distance : " + "0" + " km";
       }
       public void Reset()
       {
           Distance = "";
           Price = "";
           Efficiency = "";
            PriceResult = "Price : " + "0" + " EUR";
        }

       public void CalculateDistance()
       {
           var tempPrice = double.Parse(TotalPrice)/double.Parse(Price);
           DistanceResult = "Distance : " + Math.Round(((tempPrice/double.Parse(Efficiency))*100)).ToString() + " km";
       }
       public void CalculatePrice()
       {
           var distanceInKm = double.Parse(Distance)/100;
           var value = double.Parse(Efficiency)*distanceInKm;
           PriceResult= "Price : "+(value*double.Parse(Price)).ToString()+" EUR";
           
       }
    }
}

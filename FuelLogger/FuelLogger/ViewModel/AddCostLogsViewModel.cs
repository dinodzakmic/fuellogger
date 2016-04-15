using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelLogger.ViewModel
{
   public class AddCostLogsViewModel : MainViewModel
   {
      

       public List<string> TypeOfProduct = new List<string>();
        public AddCostLogsViewModel()
        {
            TypeOfProduct.Add("Service");
            TypeOfProduct.Add("Fuel");
            TypeOfProduct.Add("Accessories");
            TypeOfProduct.Add("Parking");
        }

       private DateTime _date= DateTime.Now;

       public DateTime Date
       {
           get { return _date; }
           set
           {
               _date = value;
               RaisePropertyChanged(()=>Date);
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
                RaisePropertyChanged(() => PriceWithCurr);
            }
        }

        private string _priceWithCurr;

        public string PriceWithCurr
        {
            get { return _priceWithCurr=_price + " EUR"; }
            set
            {
                _priceWithCurr = value;
                RaisePropertyChanged(() => PriceWithCurr);
            }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                RaisePropertyChanged(() => Description);
            }
        }

        private string _selectedProduct;

       public string SelectedProduct
       {
           get { return _selectedProduct;}
           set
           {
               _selectedProduct = value;
               RaisePropertyChanged(()=>SelectedProduct);
           }
       }
       private string _productImage;

       public string productImage
       {
           get {  return _productImage;}
           set
           {
               _productImage = value;
               RaisePropertyChanged(()=>productImage);
           }
       }
   }
}

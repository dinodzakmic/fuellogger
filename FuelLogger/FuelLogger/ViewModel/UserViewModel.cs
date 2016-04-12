using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PCLStorage;

namespace FuelLogger.ViewModel
{
   public  class UserViewModel: MainViewModel
   {
       private string _profilePicture="car.jpg";

       public string ProfilePicture
       {
           get { return _profilePicture; }
           set
           {
               _profilePicture = value;
               RaisePropertyChanged(()=>ProfilePicture);
           }
       }

       private string _carType = "CarType";

       public string CarType
       {
           get { return _carType;}
           set
           {
               _carType = value;
               RaisePropertyChanged(() => CarType);
           }
       }
        private string _carYear = "CarYear";

        public string CarYear
        {
            get { return _carYear; }
            set
            {
                _carYear = value;
                RaisePropertyChanged(() => CarYear);
            }
        }
        private string _carHP = "CarHP";

        public string CarHP
        {
            get { return _carHP; }
            set
            {
                _carHP = value;
                RaisePropertyChanged(() => CarHP);
            }
        }
        public UserViewModel()
       {
           
       }

       
   }
}

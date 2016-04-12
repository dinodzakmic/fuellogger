using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelLogger.Model
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Icon { get; set; }

        public MenuItem (string name, string icon)
        {
            Name = name;
            Icon = icon;
        }

        public MenuItem()
        {
            
        }
    }
}

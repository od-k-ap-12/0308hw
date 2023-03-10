using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0308hw
{
    class Device
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public Device(string _Model, string _Manufacturer, double _Price)
        {
            Model = _Model;
            Manufacturer = _Manufacturer;
            Price = _Price;
        }

    }
}

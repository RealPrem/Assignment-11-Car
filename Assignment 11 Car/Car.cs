using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_11_Car
{
    class Car
    {
        public string Colour;
        public string Brand;
        public int Year;

        public Engine Engine;
        public Passenger Driver;
        public Passenger Shotgun;
        public Passenger Backseat;

        public Car(string Colour, string Brand, int Year)
        {
            this.Colour = Colour;
            this.Brand = Brand;
            this.Year = Year;

        }
    }

}

using System;

namespace Assignment_11_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car MyCar = new Car("Pink", "Toyota", 2022);

            Engine MyEngine = new Engine(1000);
            Passenger Driver = new Passenger("MrInntouch");
            Passenger Shotgun = new Passenger("Empty");
            Passenger BackSeat = new Passenger("Still Empty");


            MyCar.Driver = Driver;
            MyCar = null;
            Console.WriteLine(Driver.Name);
            Console.WriteLine(MyEngine.HorsePower);
        }
    }
}

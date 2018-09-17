using System;
using SuperElectricCarRental.Domain;
namespace SuperElectricCarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Car TestCar = new Car("12345","Toyota","BigPhatEngine",500,"THX",true,true);
            Motorbike TestBike = new Motorbike("12345","ToyotaBike","RoflCopterEngine", 100, true);  
        }
    }
}

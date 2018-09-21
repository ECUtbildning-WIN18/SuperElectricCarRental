using System;
using System.Collections.Generic;

namespace SuperElectricCarRental.Domain
{
    class Vehicle
    {
        private string Brand { get; }
        private string Model { get; }
        private string RegistrationNumber { get; }
        private int FuelCapacity { get; } // How much gas can the vehicle hold? Might be relevant?
        private int Price { get; }

        public Vehicle(string brand, string model, string registrationNumber, int fuelCapacity, int price)
        {
                     Brand = brand;
            Model = model;
            RegistrationNumber = registrationNumber;
            FuelCapacity = fuelCapacity;
            Price = price;
            
        }
        public void WriteStats()
        {
            Console.Write("Brand: "+Brand+ " Model: "+ Model+ " RegNumber: "+ RegistrationNumber+
                " FuelCapacity: "+FuelCapacity+"\nPrice: "+Price+"\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SuperElectricCarRental.Domain
{
    abstract class Vehicle
    {
        public string RegistrationNumber { get; }
        public string Model { get; }
        public int Price { get; }

        public Vehicle(string registrationNumber, string model, int price)
        {
            RegistrationNumber = registrationNumber;
            Model = model;
            Price = price;
        }
    }
}

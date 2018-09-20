using System;
using System.Collections.Generic;
using System.Text;

namespace SuperElectricCarRental.Domain
{
    class Car : Vehicle
    {
        public Car(string registrationNumber, string model, int price) : base(registrationNumber, model, price)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SuperElectricCarRental.Domain
{
    class CarHolder
    {
        //private Car[] cars = new Car[5];
        private Car[] AvailableCars;
        private Car[] RentedCars;
        public CarHolder()
        {
            AvailableCars = new Car[] {
                new Car("1. Toyota", "12345", "Lexus", 100, "SONY", true, 50, 5000),
                new Car("2. Volvo", "11345", "V70", 50, "SONY", false, 60, 5000),
                new Car("3. BMW", "54321", "Best Car Ever", 75, "SONY", true, 40, 5000),
                new Car("4. Maclaren", "22345", "P1", 100, "SONY", true, 55, 5000),
                new Car("5. Porsche", "32345", "Panamera", 100, "SONY", true, 74, 5000)
            };
            RentedCars = new Car[] {
                new Car("3. BMW", "54321", "Best Car Ever", 75, "SONY", true, 40, 5000),
            };
        }

        public Car[] GetCars()
        {
            return AvailableCars;
        }

        public Car[] GetRentedCars()
        {
            return RentedCars;
        }
    }
}

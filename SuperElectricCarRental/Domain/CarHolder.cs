using System;
using System.Collections.Generic;
using System.Text;

namespace SuperElectricCarRental.Domain
{
    class CarHolder
    {
        //private Car[] cars = new Car[5];
        private Car[] cars;
        public CarHolder()
        {
            //cars[0] = new Car("Toyota", "12345", "Lexus", 100, "SONY", true, true, 5000);
            //cars[1] = new Car("Volvo", "11345", "V70", 50, "SONY", false, true, 5000);
            //cars[2] = new Car("BMW", "54321", "Best Car Ever", 75, "SONY", true, true, 5000);
            //cars[3] = new Car("Maclaren", "22345", "P1", 100, "SONY", true, true, 5000);
            //cars[4] = new Car("Porsche", "32345", "Panamera", 100, "SONY", true, true, 5000);
            cars = new Car[] {
                new Car("1. Toyota", "12345", "Lexus", 100, "SONY", true, true, 5000),
                new Car("2. Volvo", "11345", "V70", 50, "SONY", false, true, 5000),
                new Car("3. BMW", "54321", "Best Car Ever", 75, "SONY", true, true, 5000),
                new Car("4. Maclaren", "22345", "P1", 100, "SONY", true, true, 5000),
                new Car("5. Porsche", "32345", "Panamera", 100, "SONY", true, true, 5000)
            };
        }
        public Car[] GetCars()
        {
            return cars;
        }
    }
}
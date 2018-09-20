using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SuperElectricCarRental.Domain
{
    class Transaction
    {
        public Customer Customer { get;}
        public Car Car { get; }
        public DateTime Date { get; } = DateTime.Now;

        public Transaction(Customer customer, Car car)
        {
            Customer = customer;
            Car = car;
        }

        public void Receipt()
        {
            Console.WriteLine($"{Customer.FirstName} {Customer.LastName} have booked the car {Car.Model} for {Car.Price:C} a week." +
                              $" Booking date {Date}");
        }
    }
}

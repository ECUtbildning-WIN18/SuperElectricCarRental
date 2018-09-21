using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SuperElectricCarRental.Domain
{
    class Menu
    {
        public void MainMenu(Car[] cars)
        {
            Console.Clear();
            Console.WriteLine("SuperElectricCarRental");
            Console.WriteLine("1. Show Cars");
            Console.WriteLine("2. Show Motorbikes");
            Console.WriteLine("3. Exit");

            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CarMenu(cars);
                    break;
                case 2:
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

       

        public void CarMenu(Car[] cars)
        {
            Console.Clear();
            Console.WriteLine("=====CHOOSE A CAR=====");
            int i = 1;
            foreach (Car car in cars)
            {
                Console.WriteLine($"{i}. Model {car.Model}, Price: {car.Price}");
                i++;
            }
            Console.WriteLine("4. Go back");
            int carChoice = Int32.Parse(Console.ReadLine());

            if (carChoice == 4)
            {
                MainMenu(cars);
            }

            int chosenCar = carChoice - 1;

            Console.WriteLine($"You Have Chosen: {cars[chosenCar].Model}. Do you wish to rent this car? y/n");
            string confirm = Console.ReadLine();
            switch (confirm)
            {
                case "y":

                    Console.WriteLine("Enter Your Name");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter your Last Name");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter Your Social Security Number");
                    long socialSecurityNumber = long.Parse(Console.ReadLine());
                    Customer customer = new Customer(firstName, lastName, socialSecurityNumber);

                    Console.Clear();
                    Transaction transaction = new Transaction(customer, cars[chosenCar]);
                    transaction.Receipt();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("returning to menu");
                    CarMenu(cars);
                    break;
            }
        }
    }
}

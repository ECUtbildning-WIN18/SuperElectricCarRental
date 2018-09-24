using System;
using System.Collections.Generic;
using System.Text;

namespace SuperElectricCarRental.Domain
{
    class Management
    {
        
        CarHolder Cars = new CarHolder();
        private Car[] AvailableCars;
        private Car[] RentedCars;

        public Management()// Constructor
        {
            AvailableCars = Cars.GetCars(); // Makes RentableCars(from this class) == RentableCars(fromCarholder)
            RentedCars = Cars.GetRentedCars();// same as above but for the rented cars
        }

        public void ManagementMenu() // The Main Menu for admins
        {
            while (true) { 
            Console.WriteLine("1.Add Car\n2.Delete Car\n3.List Available Cars\n4.Exit");
                // Chose what you want to do, add cars delete cars etc
              string choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                    AddCar(); // calls on the private method to Add Car to our inventory ( IN DEVELOPMENT)
                    break;
                    case "2":
                    DeleteCar(); // git nuke Car ( IN DEVELOPMENT)
                    break;
                    case "3": // Easy way to list all the objects
                        int i = 1;// i is outside the loop otherwise its always gonna be 1.
                        foreach (Car car in AvailableCars)// Writes every car in AvailabeCars, and its proporties 
                        {
                            Console.Write(i + ". ");
                            car.WriteStats();
                            i++;
                        }
                        break;
                    case "4": // Exits the application
                    Environment.Exit(0);
                    break;
                    default: // Select Better Please :)
                    Console.WriteLine("Invalid Selection");
                    break;
                }
            }
        }
       
        private void AddCar() // So this is where we make code for adding cars, havn't figured this out yet.
        {
            
            Console.ReadLine();
        }
        private void DeleteCar() // This is where we make code for deleting cars, havn't gotten here yet.
        {
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace SuperElectricCarRental.Domain
{
    class Menu
    {
        CarHolder Cars = new CarHolder();
        private Car[] AvailableCars;
        private Car[] RentedCars;
        private int NumberofCars { get; set; } = 0;
        private int NumberofRentedCars { get; set; } = 0;
        Coustomer Buyer { get; }
        public Menu()// Constructor
        {
            AvailableCars = Cars.GetCars(); // Makes RentableCars(from this class) == RentableCars(fromCarholder)
            RentedCars = Cars.GetRentedCars();// same as above but for the rented cars
        }
        //Car[] OurCars =
        //   {
        //       new Car("Toyota","12345","Lexus",100,"SONY",true,250,5000),
        //       new Car("Volvo","11345","V70",50,"SONY",false,100,5000),
        //       new Car("BMW","54321","Best Car Ever",75,"SONY",true,500,5000),
        //    };
        //Car[] RentedCars = new Car[500];

        public void VehicleMenu() {
         Console.WriteLine("SuperElectriCarRental\n\nSelect Vehicle:\n" +
             "1.Cars\n2.Motorbikes ( In Development )\n3.Exit");
          string Choise = Console.ReadLine();
            Console.Clear();
                switch(Choise)
                {
                    case "1":
                    CarMenu();
                    break;
                    case "2": 
                    break;
                    case "3": // Exit
                    Environment.Exit(0); 
                    break;
                    default:
                    Console.WriteLine("Invalid Selection");
                    break;
                }
        Console.ReadLine();
        Console.Clear();
        }
       
        public void CarMenu()
        {
            bool end = false;
            while (end == false) { 
            Console.WriteLine("SuperElectriCarRental\n\n1.Show Offers (List)\n2.Rent Car\n3.Back");
            string Choise = Console.ReadLine();
            //Console.Clear();
            switch (Choise)
            {
                case "1":
                DisplayCars(); // Shows a List of Cars that you can Rent
                 break;
                case "2":
                RentCar(); // After looking at the list you can go to the Renting part
                 break;
                case "3": // Exit
                end = true;// Ends Carmenu loop, the program goes back to VehicleMenu
                 break;
                default:
                Console.WriteLine("Invalid Selection");
                 break;
            }
          }
        }

        public void DisplayCars()
        {
            int i = 1;
            foreach (Car car in AvailableCars)
            {
                Console.Write(i +". ");
                car.WriteStats();
                i++;
            }
        }
        public void RentCar()
        {

            Console.WriteLine("Please enter the number of the car you wish to rent");
            int choise = Convert.ToInt32(Console.ReadLine());
            RentedCars[NumberofRentedCars] = AvailableCars[choise-1]; //Chosen Card is now "rented"
            NumberofRentedCars++;


            Console.WriteLine("Enter your Name:"); 
            string BuyerName = Console.ReadLine();
            Console.WriteLine("Enter your SocialSecurityNumber:");
            int BuyerSocialSecurityNumber = Convert.ToInt32(Console.ReadLine()); //string maybe? 
            //(Cardnumer, Money, Owner, cvs, name, Socailsecurity number)
            Coustomer Buyer = new Coustomer(BuyerName, BuyerSocialSecurityNumber);
            // Now we have created a "buyer" that typed in his relevant information, 
            // im thinking we need creditcard details around here to later maybe?

            DateTime Date = DateTime.Now; 
            string CurrentDate = Convert.ToString(Date);
            Transactions transaction = new Transactions(Buyer.GetName(), 100, CurrentDate);
            Console.WriteLine("\n\n"+BuyerName +" Rented "+ AvailableCars[choise - 1].GetCarName());
            Console.WriteLine("Transaction Date: "+ CurrentDate +"\nPrice Total:" + AvailableCars[choise - 1].GetPrice());
            Console.ReadLine();
            Console.Clear();
        }
    }
}
// EXPORT TO FILE: System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteText.txt", stuff);
//IMPORT FROM FILE: stuff[i] = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");
//public void AddCar(string brand)
//{
//    CarList[NumberofCars] = brand; // Saves the brand name for DIsplayVehicles
//    NumberofCars++;
//}
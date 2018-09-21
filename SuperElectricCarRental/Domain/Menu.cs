using System;
using System.Collections.Generic;

namespace SuperElectricCarRental.Domain
{
    class Menu
    {
        private CarHolder ch = new CarHolder();
        private string[] CarList { get; } = { "Dummy 1", "Dummy 2" };
        private string[] RentedCarList { get; } = { "Dummy 1" };
        private int NumberofCars { get; set; } = 0;
        private int NumberofRentedCars { get; set; } = 0;
        Coustomer Buyer { get; }
        //Car[] OurCars =
        //   {
        //       new Car("Toyota","12345","Lexus",100,"SONY",true,true,5000),
        //       new Car("Volvo","11345","V70",50,"SONY",false,true,5000),
        //       new Car("BMW","54321","Best Car Ever",75,"SONY",true,true,5000),
        //    };
        

        public void VehicleMenu() {
         Console.WriteLine("SuperElectricCarRental\n\nSelect Vehicle:\n" +
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
                    DisplayCars();
                    break;
                case "2":
                    RentCar();
                    break;
                case "3": // Exit
                        end = true;
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
          }
        }
        public void AddCar(string brand)
        {
            CarList[NumberofCars] = brand; // Saves the brand name for DIsplayVehicles
            NumberofCars++;
        }
        public void DisplayCars()
        {
            Car[] OurCars = ch.GetCars();
            foreach (Car car in OurCars)
            {
                car.WriteStats();
            }
        }
        public void RentCar()
        {

            Console.WriteLine("Please enter the car you wish to rent");
            int choise = Convert.ToInt32(Console.ReadLine());
            RentedCarList[NumberofRentedCars] = CarList[choise]; // Saves the brand name for DIsplayVehicles
            NumberofRentedCars++;
            DateTime Now = DateTime.Now;
            string CurrentDate = Convert.ToString(Now);
            Console.WriteLine("Enter your Name:");
            string BuyerName = Console.ReadLine(); // Släng in en coustomer här senare
            Transactions transaction = new Transactions(BuyerName, 1000, CurrentDate);
        }
    }
}
// EXPORT TO FILE: System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteText.txt", stuff);
//IMPORT FROM FILE: stuff[i] = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");
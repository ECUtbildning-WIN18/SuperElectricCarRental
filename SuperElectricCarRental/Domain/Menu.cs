using System;
using System.Collections.Generic;

namespace SuperElectricCarRental.Domain
{
    class Menu
    {
        private string[] CarList { get; } = { "Dummy 1", "Dummy 2" };
        private string[] RentedCarList { get; } = { "Dummy 1" };
        private int NumberofCars { get; set; } = 0;
        private int NumberofRentedCars { get; set; } = 0;
        Coustomer Buyer { get; }

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
                    VehicleMenu();
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }
        public void AddCar(string brand)
        {
            CarList[NumberofCars] = brand; // Saves the brand name for DIsplayVehicles
            NumberofCars++;
        }
        public void DisplayCars()
        {
            foreach (string brand in CarList)
            {
                Console.WriteLine(brand);
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
            string BuyerName = Buyer.GetName();
            Transactions transaction = new Transactions(BuyerName, 1000, CurrentDate);
        }
    }
}
// EXPORT TO FILE: System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteText.txt", stuff);
//IMPORT FROM FILE: stuff[i] = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");
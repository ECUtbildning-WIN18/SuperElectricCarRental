using System;
using SuperElectricCarRental.Domain;
namespace SuperElectricCarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Clear();
                Console.WriteLine("Super Electric Car Rental\n1. Coustomer\n2. Admin\n3. Exit");
                // Chose if you are a Coustomer or Admin
                string choise = Console.ReadLine();
                Console.Clear();
              switch (choise)
              {
                case "1": // this will take the Coustomer to the Menu Class where he/she can do all the Carrenting stuff
                    Menu MainMenu = new Menu();// Creates a Main Menu
                    while (true){ 
                    MainMenu.VehicleMenu(); // That will loop until the User exits the program.
                    }
                break;
                case "2": // this will take the Admin to the Admin Menu, if he can provide the Password
                    string Password = "Change Me"; // This is the password :)
                    Console.WriteLine("Enter Admin Password");
                    choise = Console.ReadLine();
                    if (choise == Password) // if what you written is the password, continue 
                    {
                    Console.Clear();
                    Management MainManagementMenu = new Management(); // Creates the Admin Menu
                    MainManagementMenu.ManagementMenu();// And now we go into the admin menu
                    }else // If you can't provide the password you get this
                    {
                    Console.WriteLine("Invalid Selection");
                    }
                    Console.ReadLine();
                break;
                case "3": // Exits the Application
                    Environment.Exit(0);
                break;
                default: // Select better damn it :p!
                    Console.WriteLine("Invalid Selection");
                break;
              }
                Console.ReadLine();
            }
        }
    }
}

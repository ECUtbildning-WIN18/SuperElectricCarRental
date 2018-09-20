using SuperElectricCarRental.Domain;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace SuperElectricCarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            
            Car[] cars =
            {
                new Car("ABC123", "Tesla Model3", 2000),
                new Car("ABC124", "Volvo Electriccar", 1500),
                new Car("ABC125", "Rolls Royce Electric", 4000),
            };
         
            menu.MainMenu(cars);
          
           //int menuChoice = Int32.Parse(Console.ReadLine());
           //menu.MainMenuChoice(menuChoice,cars); 
           //int carChoice = Int32.Parse(Console.ReadLine());
           // menu.CarChoice(carChoice,cars);
        }

        
    }
}
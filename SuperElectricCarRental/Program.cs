using System;
using SuperElectricCarRental.Domain;
namespace SuperElectricCarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu MainMenu = new Menu();
            while(true)
            MainMenu.VehicleMenu();            
        }
    }
}

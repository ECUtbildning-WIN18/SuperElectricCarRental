using System;

namespace SuperElectricCarRental.Domain
{
    class Menu
    {
       public void ShowMenu() {
         Console.WriteLine("SuperElectriCarRental\n" +
         "1.List Cars\n2.Rent Cars\n3.Exit");
          string Choise = Console.ReadLine();
                switch(Choise)
                {
                    case "1": 
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
    }
}
// EXPORT TO FILE: System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteText.txt", stuff);
//IMPORT FROM FILE: stuff[i] = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");
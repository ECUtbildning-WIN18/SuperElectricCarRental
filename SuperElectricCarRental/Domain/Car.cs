using System;
<<<<<<< HEAD

namespace SuperElectricCarRental.Domain
{
    class Car : Vehicle
    {
        private string SoundSystem { get; }
        private bool HasCupHolder { get;  }
        private bool HasTrunk { get; } // Har bilen Baggage utrymme ?
        
        public Car(string brand, string registrationnumber, string model, int fuelCapacity, 
                    string soundSystem, bool hasCupHolder, bool hasTrunk,int price) 
            : base(brand, model, registrationnumber, fuelCapacity, price)
        {
            SoundSystem = soundSystem;
            HasCupHolder = hasCupHolder;
            HasTrunk = hasTrunk;
        }
       
    }
=======
using System.Collections.Generic;
using System.Text;

namespace SuperElectricCarRental.Domain {
  class Car : Vehicle {
    public void StartEngine() {
      Console.WriteLine("VROOOMMM....");
    }
  }
>>>>>>> 55f8835ee496328a63c24e8c4ccd825589a3af0f
}

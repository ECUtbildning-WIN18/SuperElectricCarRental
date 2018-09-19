using System;

namespace SuperElectricCarRental.Domain
{
    class Car : Vehicle
    {
        private string SoundSystem { get; }
        private bool HasCupHolder { get;  }
        private bool HasTrunk { get; } // Har bilen Baggage utrymme ?
        

        public Car(string brand, string registrationnumber, string model, int fuelCapacity, 
                    string soundSystem, bool hasCupHolder, bool hasTrunk) 
            : base(brand, registrationnumber, model,  fuelCapacity)
        {
            SoundSystem = soundSystem;
            HasCupHolder = hasCupHolder;
            HasTrunk = hasTrunk;
        }
       
    }
}

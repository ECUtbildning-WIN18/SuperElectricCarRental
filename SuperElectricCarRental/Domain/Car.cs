using System;

namespace SuperElectricCarRental.Domain
{
    class Car : Vehicle
    {
        private string SoundSystem { get; }
        private bool HasCupHolder { get;  }
        private int TrunkSpace { get; } // Har bilen Baggage utrymme ?
        
        public Car(string brand, string registrationnumber, string model, int fuelCapacity, 
                    string soundSystem, bool hasCupHolder, int hasTrunk,int price) 
            : base(brand, model, registrationnumber, fuelCapacity, price)
        {
            SoundSystem = soundSystem;
            HasCupHolder = hasCupHolder;
            TrunkSpace = hasTrunk;
        }
    }
}

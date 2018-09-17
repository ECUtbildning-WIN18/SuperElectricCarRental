namespace SuperElectricCarRental.Domain
{
    class Car : Vehicle
    {
        private string SoundSystem { get;}
        private bool HasCupHolder { get;}
        private bool HasTrunk { get; } // Har bilen Baggage utrymme ?

        public Car(string registrationnumber, string model, string engingename, int fuelCapacity, 
                    string soundSystem, bool hasCupHolder, bool hasTrunk) 
            : base(registrationnumber, model, engingename, fuelCapacity)
        {
            SoundSystem = soundSystem;
            HasCupHolder = hasCupHolder;
            HasTrunk = hasTrunk;
        }
    }
}

namespace SuperElectricCarRental.Domain
{
    class Vehicle
    {
        private string Model { get; }
        private string RegistrationNumber { get; }
        private string EngineName { get;}
        private int FuelCapacity { get; } // How much gas can the vehicle hold? Might be relevant?
        
        public Vehicle(string model, string registrationNumber, string engineName, int fuelCapacity)
        {
            Model = model;
            RegistrationNumber = registrationNumber;
            EngineName = engineName;
            FuelCapacity = fuelCapacity;
        }
    }
}

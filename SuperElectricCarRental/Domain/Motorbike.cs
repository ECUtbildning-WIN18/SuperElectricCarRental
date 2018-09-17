namespace SuperElectricCarRental.Domain
{
    class Motorbike : Vehicle
    {
        private bool Handlebars { get; set; }

        public Motorbike(string registrationNumber, string model,string engingename, int fuelCapacity, bool handlebars) 
                  : base(registrationNumber, model, engingename, fuelCapacity)
        {
            Handlebars = handlebars;
        }
    }
}

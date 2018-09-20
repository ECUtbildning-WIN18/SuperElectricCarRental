using System;
using System.Collections.Generic;
using System.Text;

namespace SuperElectricCarRental.Domain
{
    class Customer
    {
        public string FirstName { get; }
        public string LastName { get; }
        public long SocialSecurityNumber { get; }

        public Customer(string firstName, string lastName, long socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }
    }
}

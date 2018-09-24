using System;
using System.Collections.Generic;
using System.Text;

namespace SuperElectricCarRental.Domain
{
    class Coustomer // : CreditCard 
    {
        private string Name { get; }
        private int SocialSecurityNumber { get; }

        public Coustomer( string name,int socialSecurityNumber)
        //int cardNumber, int curentValue, string owner, int cSV, : base (cardNumber, curentValue, owner, cSV )
        {
            Name = name;
            SocialSecurityNumber = socialSecurityNumber;
            // We now have a Coustomer with a Name and working CreditCard
        }

        public string GetName()
        {
            return Name;
        }
    }
}

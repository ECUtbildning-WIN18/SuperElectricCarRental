using System;
using System.Collections.Generic;
using System.Text;

namespace SuperElectricCarRental.Domain
{
    class Coustomer : CreditCard // A Coustomer must have a Credit Card
    {
        private string Name { get; }
        private int SocialSecurityNumber { get; }

        public Coustomer(int cardNumber, int curentValue, string owner, int cSV, string name,int socialSecurityNumber)
                 : base (cardNumber, curentValue, owner, cSV )
        {
            Name = name;
            SocialSecurityNumber = socialSecurityNumber;
            // We now have a Coustomer with a Name and working CreditCard
        }
    }
}

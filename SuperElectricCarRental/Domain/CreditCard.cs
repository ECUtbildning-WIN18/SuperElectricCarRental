using System;
using System.Collections.Generic;
using System.Text;

namespace SuperElectricCarRental.Domain
{
    class CreditCard
    {
        private int CardNumber { get;   }
        private int CurentValue { get; set; }
        private string Owner { get;    }
        private int CSV { get;  }

        public CreditCard(int cardNumber, int curentValue, string owner, int cSV)
        {
            CardNumber = cardNumber;
            CurentValue = curentValue;
            Owner = owner;
            CSV = cSV;
        }
    }
}

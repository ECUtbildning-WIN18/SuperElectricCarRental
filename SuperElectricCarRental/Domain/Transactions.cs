using System;
using System.Collections.Generic;
using System.Text;

namespace SuperElectricCarRental.Domain
{
    class Transactions
    {
            string Buyer { get;}
            int Money { get;}
            string Date { get; set; }

        public Transactions(string buyer, int money, string date)
        {
            Buyer = buyer  ;
            Money = money;
            Date = date;
        }
    }
}


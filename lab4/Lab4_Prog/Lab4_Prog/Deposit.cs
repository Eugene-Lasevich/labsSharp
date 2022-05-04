using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Prog
{
    internal class Deposit
    {
        private double ammount = 100;
        public double Ammount
        {
            get { return ammount; }
            set { ammount = value; }
        }

        private Deposit() { }

        private static Deposit deposit;

        public static Deposit GetInstance()
        {
            if (deposit == null)
            {
                deposit = new Deposit();
                return deposit;
            }    
            else
                return deposit;
        }
    }
}

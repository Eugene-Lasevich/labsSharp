
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Prog
{
    public class Bank
    {

        private string name = "Undefined";
        private int numOfDeposits = 1;
        private double interestRate = 1;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int NumOfDeposits
        {
            get { return numOfDeposits; }
            set { numOfDeposits = value; }
        }

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public double CalculateRevenue(int period)
        {
            double revenue = 0;
            Deposit deposit = Deposit.GetInstance();
            for (int i = 0; i < period; i++)
            {
                revenue += deposit.Ammount * (InterestRate / 100.0);
                deposit.Ammount += deposit.Ammount * (InterestRate / 100.0);
            }
            return revenue * NumOfDeposits;
        }
    }
}

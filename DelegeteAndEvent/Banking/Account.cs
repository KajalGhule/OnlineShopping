using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public delegate void AccountHandler(); // delegate

    public class Account
    {
        private float balance;

        public event AccountHandler underBalance; //event
        public event AccountHandler overBalance; // event
         public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account(float balance)
        {
            Balance = balance;
        }
        public void Monitor()
        {
            if (Balance < 500)
            {   //trigger
                underBalance();
            }
            else if (Balance >= 250000) {
                //trigger
                overBalance();
            }
        }
        //Static behaviour
        public void Deposit(float amount)
        {
            Balance += amount;
            Monitor();
        }
        public void Withdraw(float amount)
        {
            Balance -= amount;
            Monitor();
        }
        //Dynamic behaviour
        //underbalance or ovverbalance

        public override string ToString()
        {
            return "Balance is " + this.Balance + ".";
        }

        
    }
}

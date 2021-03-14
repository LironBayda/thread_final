using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bankQuestion5
{
  public  class Bank
    {

        private Dictionary<int, Customer> customers = new Dictionary<int,Customer>();
        public  event EventHandler<BalanceEventArgs>  minusBalnce;

        

        public void AddCustomer(string name, string address, int accountNum, int phoneNum, int balance)
        {
            Customer customer = new Customer(name, address, accountNum, phoneNum, balance);
            customers.Add(accountNum, customer);
        
        }

        //change balance amount can be negative or positive  
        public void ChangeBalance(int accountNum,int amount)
        {
            customers[accountNum].Balance += amount;
            if (customers[accountNum].Balance < 0)
                onMinusBalance(customers[accountNum].Balance);
        }

        private void onMinusBalance(int balance)
        {
            if (minusBalnce != null)
            {
                BalanceEventArgs balanceEventArgs = new BalanceEventArgs
                {
                    Balance = balance
                };

                minusBalnce.Invoke(this, balanceEventArgs);
            }
        }
    }
}

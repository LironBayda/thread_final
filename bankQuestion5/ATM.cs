using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankQuestion5
{
    class ATM
    {

        static public void withdraw(int amount, int accuontNum,Bank bank)
        {
            bank.ChangeBalance(accuontNum, amount);
        }

       static public void ShowWarningEvenetHandlet(object o, BalanceEventArgs balanceEventArgs)
        {
            Console.WriteLine("ATM: you have minus balance");
        
        }
    }
}

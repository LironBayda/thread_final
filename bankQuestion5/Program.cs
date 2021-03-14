using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bankQuestion5
{
    class Program
    {
        //answers to 5 and 6 in the pdf file
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            otherThingToDoWhenCustomerGetMinusBalance otherThingToDoWhenCustomerGetMinusBalance = new otherThingToDoWhenCustomerGetMinusBalance();
            bank.minusBalnce += ATM.ShowWarningEvenetHandlet;
            bank.minusBalnce += otherThingToDoWhenCustomerGetMinusBalance.somethingToDoWhenCustomerGetMinusBalanceEventHundler;
            bank.AddCustomer("avi", "a street", 223938290, 0543754568, 10000);
            ATM.withdraw( -100000000, 223938290, bank);
            Console.ReadLine();
            
        }
    }
}

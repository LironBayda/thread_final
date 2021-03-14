using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankQuestion5
{
    class otherThingToDoWhenCustomerGetMinusBalance
    {
     public   void somethingToDoWhenCustomerGetMinusBalanceEventHundler(object o, BalanceEventArgs balanceEventArgs)
        {
            Console.WriteLine("somthing to do when customer get minus balance");
        
        }
    }
}

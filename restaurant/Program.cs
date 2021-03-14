using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitchen kitchen = new Kitchen();
            Waiter waiter = new Waiter();
            kitchen.DishReady += waiter.OnDishReady;
            kitchen.PrepareDish();
            Console.ReadLine();
        }
    }
}

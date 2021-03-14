using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    class Waiter
    {
        public void OnDishReady(object o,DishEventArgs dishEventArgs)
        {
            Console.WriteLine(" Serving the dish to the Coustumer  ");
            Console.WriteLine("dish name: " + dishEventArgs.DishName);
        }
    }
}

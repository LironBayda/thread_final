using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    class Kitchen
    {
        public event EventHandler<DishEventArgs> DishReady;

        public void PrepareDish()
        {
            Console.WriteLine(" Preparing dish ... ");
            OnDishReady();
        }

        private void OnDishReady()
        {
            if (DishReady != null)
            {
                DishEventArgs dishEventArgs = new DishEventArgs
                {
                    DishName = "dishName"
                };
                
                DishReady.Invoke(this, dishEventArgs);

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace question14
{
    class Program
    {
         public   delegate  void DelForA();
         public delegate void DelForB(object stateInfo);


       static void delForB (object stateInfo) 
        {

            object[] arr = stateInfo as object[];
            int num1 = Convert.ToInt32(arr[0]);
            int num2 = Convert.ToInt32(arr[1]);
            Console.WriteLine(num1 * num2);
        }
        static void Main(string[] args)
        {
            DelForA delForA = new DelForA(() =>
              {
                  Console.WriteLine("Downloading file...");
                  Thread.Sleep(10000);
                  Console.WriteLine("Completed");
              });

              

          

            new Thread(()=>delForA()).Start();

            ThreadPool.QueueUserWorkItem(delForB, new object[] { 2, 3 });

            Console.ReadLine();
        }

     
    }
}

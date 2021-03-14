using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace question22
{
    class Program
    {
        static ManualResetEvent hostForA = new ManualResetEvent(false);
        static AutoResetEvent hostForB = new AutoResetEvent(false);


        static void  EnterClubForA()
        {
            Console.WriteLine("waiting to enter...");
            hostForA.WaitOne();
            Console.WriteLine("enter");


        }

        static void EnterClubForB()
        {
            Console.WriteLine("waiting to enter...");
            hostForB.WaitOne();
            Console.WriteLine("enter");


        }

        static void Main(string[] args)
        {
            //a
            for (int i = 0; i < 50; i++)
            {
                new Thread(EnterClubForA).Start();
            
            };

            Thread.Sleep(3000);
            hostForA.Set();



            Console.ReadLine();


            //b
            for (int i = 0; i < 50; i++)
            {
                new Thread(EnterClubForB).Start();

            };

            Thread.Sleep(3000);

            for (int i = 0; i < 50; i++)
            {
                hostForB.Set();
                Thread.Sleep(1000);

            };

            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question9
{
    class Program
    {
      static void   LongOperation ()           
      {
            for (int i = 0; i < 1000000000; i++)
            { 
            
            }
            Console.WriteLine("Done");
      }

        static void Main(string[] args)
        {
            //without thread
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 5; i++)
            {
                LongOperation();
            }

            Console.WriteLine($"without threads it took {stopwatch.Elapsed}");


            //with threads
            
            stopwatch.Restart();

            for (int i = 0; i < 5; i++)
            {
                new Thread( LongOperation).Start();
            }

            Console.WriteLine($"with threads it took {stopwatch.Elapsed}");

            Console.ReadLine();
        }
    }
}

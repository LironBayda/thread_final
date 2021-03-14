using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace question33
{
    class Program
    {
        static int count = 0;
        static CancellationTokenSource source = new CancellationTokenSource();

        static void MyTimer()
        { 
        while(!source.IsCancellationRequested)
            {
                count += 1;
                Thread.Sleep(1000);
            }
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("timer is starting");
            Task.Run(MyTimer, source.Token);
            Console.ReadLine();
            Console.WriteLine("Timer is stopped: " + count);
            Console.ReadLine();
            

        }
    }
}

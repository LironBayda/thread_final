using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace question12
{
    class Program
    {
        static List<int> listForB = new List<int> { 1, 3, 4, 5, 6, 55, 43, 332, 32, 53 };
        static void Main(string[] args)
        {
            //12 
            //a
            new Thread(() => Console.WriteLine("Hello World")).Start();
            //b
            new Thread((num) => {
               listForB.Select((int x,int i) => new { x, i }).Where(y=>y.x==(int)num).ToList()
                .ForEach(y=>Console.WriteLine($"we found {num} in index {y.i}"));
            }).Start(32);
            Console.ReadLine();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace question34
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> queue = new List<int> { 1, 2, 3, 4, 55, 44, 6, 78, 6547, 26, 4546,4,34,435,3534,34645,46,35,235,346,235,346,37,23534,6,347,235,346,5732,43634,5446,4657,436,547,436,436 };
            Workers workers = new Workers();
            workers.DoJobs(queue);
            Console.ReadLine();
        }
    }
}

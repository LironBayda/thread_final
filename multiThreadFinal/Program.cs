
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace multiThreadFinal
{
    class Program
    {
        //1. print function for 1
       static void printList(List<int> list)
        {
            list.ForEach(x => Console.Write(x+" "));
            Console.WriteLine();
            Console.WriteLine();


        }
        //2. print function for 2
        static void printList(List<string> list)
        {
            list.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine();


        }

        //3

        static public int Add(int x, int y)
        {
            return x + y;
        }

        delegate int  Del(int x,int y);

        static void Main(string[] args)
        {
            //1

            Random random = new Random();
            List<int> list = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(0, 51));
            
            }

            printList(list);
            //a.
            printList(list.Where(x => x < 10).ToList());

            var myLinqQueryA = from num in list
                              where num<10
                              select num;
            printList(myLinqQueryA.ToList());

            //b.
            printList(list.Where(x => x % 3 == 0).ToList());

            var myLinqQueryB = from num in list
                               where num % 3 == 0
                               select num;
            printList(myLinqQueryB.ToList());

            //c
            printList(list.Where(x => x > 20 && x % 2 == 0).ToList());

            var myLinqQueryC = from num in list
                               where num > 20 && num % 2 == 0
                               select num;

            printList(myLinqQueryC.ToList());

            //d.
            printList(list.OrderByDescending(x => x).ToList());

            var myLinqQueryD = from num in list
                               orderby num descending
                               select num;

            printList(myLinqQueryD.ToList());


            //2 
            List<string> list2 = new List<string>()
            {
            "Danna",
            "Liron",
            "Ofer",
            "Liat",
            "Tal",
            "Noga",
            "Pol",
            "Hana",
            "Limor",
            "Nir"
            };

            //a.
            printList(list2.Where(str=> str.Length > 4).ToList());

            var myLinqQuery2a = from str in list2
                                where str.Length >4
                               select str;
            printList(myLinqQuery2a.ToList());

            //b.
            printList(list2.Where(str => str.ToLower().Contains('a')).ToList());

            var myLinqQuery2b = from str in list2
                                where str.ToLower().Contains('a')
                                select str;
            printList(myLinqQuery2b.ToList());

            //c.
            printList(list2.OrderBy(str =>str).ToList());

            var myLinqQuery2c = from str in list2
                                orderby str
                                select str;
            printList(myLinqQuery2c.ToList());

            Console.ReadLine();

            //3
            /* static public int Add(int x, int y)
             {
                 return x + y;
             }

              delegate int  Del(int x,int y);

             */

            Del del=new Del(Add);
            Console.WriteLine(del.Invoke(1,2));

            //4.
            //a. Func
            //b. Action


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace question19
{
    class Program
    {

       static object key = new object();
        static void DoctorTreatment()
        {

            lock (key)
            {
                Console.WriteLine("Waiting for my turn");
                Monitor.Wait(key);
                Console.WriteLine("Getting treatment");
                NurseCheck();



            }
        
        }

        static private void NurseCheck()
        {
            lock (key)
            {
                Console.WriteLine("Nurse is checking");
                Thread.Sleep(5000);
                Monitor.Pulse(key);
                Console.WriteLine("Next patient please");

            }
        }


      

        static void Main(string[] args)
        {
            //pataint come and wating to the doctor
            new Thread(() => { DoctorTreatment(); }).Start();
            new Thread(() => { DoctorTreatment(); }).Start();
            new Thread(() => { DoctorTreatment(); }).Start();

            // the  doctor check if there is patient waiting for her
            lock (key)
            {

                Monitor.Pulse(key);

            }

            Console.ReadLine();
        }

    }
}

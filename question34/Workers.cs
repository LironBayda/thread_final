using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace question34
{
    class Workers
    {
        List<Task> tasks = new List<Task>() { null,null,null,null,null};
        Random random = new Random();

        public Workers()
        {
         
        }

        void DoJob(List<int> queue)
        {
            int num;
            //i dont wont that two tasks read and delete simultane
            lock (this)
            {
                if (queue.Count != 0)
                {
                    num = queue[0];
                    queue.RemoveAt(0);

                }
                else return;
            }
            Console.WriteLine(num *2);
            Thread.Sleep(1000);
           

        
        }

        public void DoJobs(List<int> queue)
        {
            for (int i = 0; i < 5; i++)
            {
                if (tasks[i] == null)

                    tasks[i] = Task.Run(() => DoJob(queue));
            }

                while (true)
            {              
                    if (queue.Count == 0)
                        break;
                
                
                for (int i = 0; i < 5; i++)
                   
                      tasks[i] = tasks[i].ContinueWith((antecedent) => DoJob(queue));
                   
                    

                
            }
        }
    }
}

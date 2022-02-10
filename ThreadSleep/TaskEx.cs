using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSleep
{
    internal class TaskEx
    {
        public static void Main7()
        {
            Task t1 = Task.Run(() => { PrintInformation(); });
            t1.Wait();
            Console.WriteLine("Main Thread completed");

        }
        static void PrintInformation()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Value of i {0}", i);
            }
            Console.WriteLine("Child Thread completed");
        }
    }
}

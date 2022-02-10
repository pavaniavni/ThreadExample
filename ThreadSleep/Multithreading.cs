using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSleep
{
    internal class Multithreading
    {
        static void Main5(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(PrintInformation));
            Thread t2 = new Thread(new ThreadStart(PrintInformation2));
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }

        static void PrintInformation()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("i value from First Function : {0}", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("First Method Completed");
        }
        static void PrintInformation2()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("i value from Second Function: {0}", i);
            }
            Console.WriteLine("Second Method Completed");
        }
    }
}

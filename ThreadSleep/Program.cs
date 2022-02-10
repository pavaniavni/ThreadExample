using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Threading
{
    internal class ExampleofThread
    {
        static void Main1(string[] args)
        {

            Stopwatch stwatch = new Stopwatch();
            stwatch.Start();

            Thread oThread = new Thread(ProcessSleep);
            oThread.Start();
            oThread.Join();
            stwatch.Stop();
            TimeSpan ts = stwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            Console.WriteLine(elapsedTime);
            Console.WriteLine("WOrk completed");
        }

       
        static void ProcessSleep()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work in progress");
                Thread.Sleep(1000);//1 second
            }

        }
    }
    }
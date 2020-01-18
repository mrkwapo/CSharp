using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Timers;
using System.Threading;
using System.Diagnostics;

namespace StopwatchExercise
{

    public class Stopwatch
    {
        public static int count = 0;
        private System.Timers.Timer timer;

        public Stopwatch()
        {

        }
        //Start Method
        public static void Start()
        {
            //int count = 0;
            while (true)
            {
                //Counting in seconds.
                Console.WriteLine(count);
                Thread.Sleep(1000);
                count++;

            }
        }

        //Stop Method
        public static void Stop()
        {
            //Task.Delay(1000);
            //var timer = new Stopwatch();
            //timer.Stop();
            var input = Console.ReadLine();
            if(String.IsNullOrEmpty(input))
            {                
                System.Environment.Exit(0);
                //Thread.Yield();
                //Console.WriteLine("Duration: " + count);
            }
            
        }

              

    }
    class Program
    {
        

        static void Main(string[] args)
       {           

            Console.WriteLine("The Start Time is: " + DateTime.Now.ToString("hh:mm"));


            Stopwatch.Start();
            Stopwatch.Stop();


        }

        
    }
}

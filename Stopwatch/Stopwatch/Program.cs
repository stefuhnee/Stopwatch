using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            while (!String.IsNullOrEmpty(Console.ReadLine()))
            {
                if (Console.ReadLine() == "start")
                    Stopwatch.Start();
                if (Console.ReadLine() == "stop")
                    Console.WriteLine(Stopwatch.Stop());
            }
        }
    }

    class Stopwatch
    {
        private static DateTime StartTime;


        public static void Start()
        {
            if (StartTime == null)
                StartTime = DateTime.Now;
           else
                throw new InvalidOperationException();
        }

        public static TimeSpan Stop()
        {
            var timeLength = DateTime.Now - StartTime;
            return timeLength;
        }
    }
}

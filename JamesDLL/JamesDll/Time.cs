using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace JamesDll
{
    public class Time
    {
        public static void WaitForSeconds(int seconds)
        {
            Console.WriteLine("Waiting " + seconds + " seconds...");
            while (Wait(TimeSpan.FromSeconds(seconds))) ;
        }
        public static void WaitForMinutes(int minutes)
        {
            Console.WriteLine("Waiting " + minutes + " minutes...");
            while (Wait(TimeSpan.FromMinutes(minutes))) ;
        }
        public static void WaitForHours(int hours)
        {
            Console.WriteLine("Waiting " + hours + " hours...");
            while (Wait(TimeSpan.FromHours(hours))) ;
        }
        private static bool Wait(TimeSpan time)
        {
            //TimeSpan milliseconds = seconds;
            var stopwatch = Stopwatch.StartNew();

            var lastVal = TimeSpan.Zero;

            while (true)
            {
                var currentVal = stopwatch.Elapsed;
                if (currentVal - lastVal < time) continue;

                lastVal = currentVal;
                break;
            }
            return false;
        }
    }
}

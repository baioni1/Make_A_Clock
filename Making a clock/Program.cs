using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_a_clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 1; hour <=12 ; hour++)//change the int hour to what ever the hour is
            {
                for (int minutes = 1; minutes <60; minutes++)//change the in minutes and it will change the minutes
                {
                    for (int seconds = 1; seconds < 60; seconds++)
                    {
                        Console.WriteLine(hour + ":" + minutes + ":" + seconds);
                        System.Threading.Thread.Sleep(1000); //It will run the clock to whatever the time is!  Awesome!
                    }
                }
            }
        }
    }
}

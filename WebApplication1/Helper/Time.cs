using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helper
{
    public class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        private static Time GetTime(string admisionDateTime)
        {
            int time;
            int hours = 0;
            var minutes = 0;
            return new Time(hours, minutes);
        }
       
    }
}

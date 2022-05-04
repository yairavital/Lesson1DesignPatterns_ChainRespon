using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1DW
{
    internal class Clock
    {
        private static Clock instance;
        private static readonly object key = new object();
        private Clock(int hour)
        {
            instance = new Clock(hour);
        }
        public static Clock GetTime()
        {
            if (instance == null)
            {lock (key)
                {
                    if (instance == null)
                    {
                        Console.WriteLine("Enter your time");
                        int hour = int.Parse(Console.ReadLine());
                        instance = new Clock(hour);
                    }
                        
                }

            }
                
            return instance;
        }
        
    }
}

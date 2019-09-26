using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock c = new Clock();
            AnalogClock ac = new AnalogClock();
            DigitalClock dc = new DigitalClock();

            ac.DK(c);
            dc.DK(c);
            c.Run();


            
        }
    }
}

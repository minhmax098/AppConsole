using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventNew
{
    class AnalogClock
    {
        public void ShowAC(object o, TimeEventArgs e)
        {
            
            Console.WriteLine("AC:{0}:{1}:{2}:{3}",e.time.Hour,e.time.Minute,e.time.Second,e.time.Millisecond);
        }

        public void DK(Clock c)
        {
            c.OnSecondChange += new Clock.SecondHandler(ShowAC);
        }
    }
}

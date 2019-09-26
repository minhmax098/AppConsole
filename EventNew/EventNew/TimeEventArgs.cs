using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventNew
{
    class TimeEventArgs  : EventArgs
    {
        public DateTime time { get; set; }

        //public TimeEventArgs(DateTime t) {
            
        //        this.time = t;
        //    } 
    }
}

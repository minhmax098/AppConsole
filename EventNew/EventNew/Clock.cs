using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventNew
{
    class Clock
    {
        //Lớp khai báo sự kiện
        public delegate void SecondHandler(Object obj, TimeEventArgs args);
        public event SecondHandler OnSecondChange;

        public void Run()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (OnSecondChange != null)
                {
                    //Kiểm tra điều kiện 
                    DateTime d = DateTime.Now;
                    OnSecondChange(this, new TimeEventArgs());    // truyền tham số this, new TimeEventArgs

                }
               


            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class SV
    {
        public int MSSV { get; set; }
        public string Name { get; set; }
        public double DHT { get; set; }
        public SV()
        {
        }
        public SV(int mssv, string name, double dht)
        {
            this.MSSV = mssv;
            this.Name = name;
            this.DHT = dht;
        }
        public void Show()
        {
            Console.WriteLine(" MSSV= {0}", MSSV);
            Console.WriteLine(" Name= {0}", Name);
            Console.WriteLine(" DHT= {0}", DHT);
        }
    }
}

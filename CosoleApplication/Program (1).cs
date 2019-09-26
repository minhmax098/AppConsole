using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class Program
    {
        static void Main(string[] args)
        {
            SV sv1 = new SV
            {
                MSSV = 111,
                Name = "A",
                DHT = 1.1
            };
            SV sv2 = new SV
            {
                MSSV = 222,
                Name = "B",
                DHT = 9.1
            };
            SV sv3 = new SV
            {
                MSSV = 333,
                Name = "C",
                DHT = 8.1
            };
            SV sv4 = new SV
            {
                MSSV = 444,
                Name = "D",
                DHT = 7.1
            };
            SV sv5 = new SV
            {
                MSSV = 555,
                Name = "E",
                DHT = 5.1
            };
            QLSV a = new QLSV();
            a.ThemSV(sv1);       
            a.ThemSV(sv2);
            a.ThemSV(sv3);
            a.ThemSV(sv4);
            /*a.ThemSV(sv4);
            a.ThemSV(sv5);
            Console.WriteLine("Danh sach SV:");
            a.Show(); 
            a.XoaSV1(3);
            Console.WriteLine("Da xoa SV thu 3 ra khoi DS:");
            a.Show();
            a.XoaSV(sv1);
            Console.WriteLine("Da xoa SV sv1 ra khoi DS:");
            a.Show();
            Console.WriteLine("Da xoa SV sv5 ra khoi DS:");
            a.XoaSV(sv5);
            a.Show();
            */
            a.Insert(3, sv5);
            a.Sort();
            //a.Show();
            int k = a.BinarySearch(sv3);
            Console.WriteLine("Vi tri tim thay: {0}", k+1);
            Console.WriteLine("Done!");
            Console.ReadKey(); 
        }
    }
}

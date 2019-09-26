using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class QLSV
    {
        // Khoi tao
        public int count { get; set; }
        public SV[] ds;
        public QLSV()
        {
            this.count = 0;
            this.ds = null;
        }
        // Them 1 SV
        public void ThemSV(SV s)
        {

            if (this.count == 0)
            {
                this.count = 1;
                this.ds = new SV[count];
                this.ds[0] = s;
            }
            else
            {
                int i = 0;
                SV[] Temp = new SV[count];
                for (i = 0; i < count; i++)
                {
                    Temp[i] = new SV();
                    Temp[i].MSSV = this.ds[i].MSSV;
                    Temp[i].Name = this.ds[i].Name;
                    Temp[i].DHT = this.ds[i].DHT;
                }

                count++;
                ds = new SV[count];

                for (i = 0; i < count - 1; i++)
                {
                    ds[i] = new SV();
                    ds[i].MSSV = Temp[i].MSSV;
                    ds[i].Name = Temp[i].Name;
                    ds[i].DHT = Temp[i].DHT;
                }
                ds[count - 1] = new SV();
                ds[count - 1].MSSV = s.MSSV;
                ds[count - 1].Name = s.Name;
                ds[count - 1].DHT = s.DHT;

            }
        }

        public void XoaSV1(int x)
        {

            SV[] Temp = new SV[count - 1];
            /*
            if (x == this.count-1)
            {
                int n = -1;
                for (int i = 0; i < this.count - 1; i++)
                {
                    n++;
                    Temp[n] = new SV();
                    Temp[n].MSSV = ds[i].MSSV;
                    Temp[n].Name = ds[i].Name;
                    Temp[n].DHT = ds[i].DHT;
                }

                count--;
                this.ds = new SV[count];
                for (int i = 0; i <= n; i++)
                {
                    ds[i] = new SV();
                    ds[i].MSSV = Temp[i].MSSV;
                    ds[i].Name = Temp[i].Name;
                    ds[i].DHT = Temp[i].DHT;
                }

            }
            else
            {*/
            int i, n = -1;
            x--;
            for (i = 0; i < x; i++)
            {
                n++;
                Temp[n] = new SV();
                Temp[n].MSSV = ds[i].MSSV;
                Temp[n].Name = ds[i].Name;
                Temp[n].DHT = ds[i].DHT;
            }
            for (i = x + 1; i < count; i++)
            {
                n++;
                Temp[n] = new SV();
                Temp[n].MSSV = ds[i].MSSV;
                Temp[n].Name = ds[i].Name;
                Temp[n].DHT = ds[i].DHT;
            }
            count--;
            this.ds = new SV[count];
            for (i = 0; i <= n; i++)
            {
                ds[i] = new SV();
                ds[i].MSSV = Temp[i].MSSV;
                ds[i].Name = Temp[i].Name;
                ds[i].DHT = Temp[i].DHT;
            }
            // }
        }
        public int TimKiem(SV s)
        {
            int i;
            for (i = 0; i < count; i++)
                if (ds[i].MSSV == s.MSSV) return i;
            return -1;
        }
        public void XoaSV(SV s)
        {
            int i = TimKiem(s);
            //Console.WriteLine("{0}", i);
            if (i != -1) XoaSV1(i + 1);

        }
        public void Insert(int index, SV s) {
            if (index <= 0 || index > this.count) return;
            SV[] Temp = new SV[count];
            index--;
            if (index==0)
            {
                for(int i = 0; i<this.count; i++)
                {
                    Temp[i] = this.ds[i];
                }
                this.count++;
                this.ds = new SV[count];
                this.ds[0] = s;
                for (int i = 0; i < this.count - 1; i++)
                    this.ds[i + 1] = Temp[i];
            }
            else if (index==this.count-1)
            {
                for (int i = 0; i < this.count; i++)
                {
                    Temp[i] = this.ds[i];
                }
                this.count++;
                this.ds = new SV[count];
                this.ds[count - 1] = s; 
                for (int i = 0; i < this.count - 1; i++)
                    this.ds[i] = Temp[i];
            }
            else
            {
                int n = -1;
                Temp = new SV[count+1];
                for (int i = 0; i<index; i++)
                {
                    n++;
                    Temp[n] = this.ds[i];
                }
                n++;
                Temp[n] = s;
                for (int i = index; i<this.count; i++)
                {
                    n++;
                    Temp[n] = this.ds[i];
                }
                this.count++;
                this.ds = new SV[count];
                for (int i=0; i<=n; i++)
                {
                    this.ds[i] = Temp[i];
                } 
            }
        }
        // sap xep theo DHT
        public void Sort()
        {
            SV temp = new SV();
            for (int i=0; i<this.count-1; i++) 
                for (int j=i+1; j<this.count; j++)
                    if (this.ds[i].DHT > this.ds[j].DHT )
                    {
                        temp = this.ds[i];
                        this.ds[i] = this.ds[j];
                        this.ds[j] = temp;
                    }
        }

        public int BinarySearch(SV s)
        {
            int l = 0;
            int r = this.count - 1;
            Sort();
            s.Show();
            while (r >= l)
            {
                int mid = (r+l) / 2;
                this.ds[mid].Show();
                if (this.ds[mid].MSSV == s.MSSV && this.ds[mid].Name==s.Name && this.ds[mid].DHT==s.DHT) return mid;
                if (this.ds[mid].DHT > s.DHT) r = mid - 1;
                //if (this.ds[mid].DHT < s.DHT)
                l = mid + 1;
            }
            return -1;
        }
        /*
        public int BinarySearch(SV s) { }
        public void Clear()
        public void Reverse()
        // sap xep theo DHT
        public void Sort()
        */
        public void Show()
        {
            int i;
            for (i = 0; i < this.count; i++)
            {
                ds[i].Show();
                Console.WriteLine();
            }
            
        }
        public void XoaSV1(int x)
        {

            SV[] Temp = new SV[count - 1];
            /*
            if (x == this.count-1)
            {
                int n = -1;
                for (int i = 0; i < this.count - 1; i++)
                {
                    n++;
                    Temp[n] = new SV();
                    Temp[n].MSSV = ds[i].MSSV;
                    Temp[n].Name = ds[i].Name;
                    Temp[n].DHT = ds[i].DHT;
                }

                count--;
                this.ds = new SV[count];
                for (int i = 0; i <= n; i++)
                {
                    ds[i] = new SV();
                    ds[i].MSSV = Temp[i].MSSV;
                    ds[i].Name = Temp[i].Name;
                    ds[i].DHT = Temp[i].DHT;
                }

            }
            else
            {*/
            int i, n = -1;
            x--;
            for (i = 0; i < x; i++)
            {
                n++;
                Temp[n] = new SV();
                Temp[n].MSSV = ds[i].MSSV;
                Temp[n].Name = ds[i].Name;
                Temp[n].DHT = ds[i].DHT;
            }
            for (i = x + 1; i < count; i++)
            {
                n++;
                Temp[n] = new SV();
                Temp[n].MSSV = ds[i].MSSV;
                Temp[n].Name = ds[i].Name;
                Temp[n].DHT = ds[i].DHT;
            }
            count--;
            this.ds = new SV[count];
            for (i = 0; i <= n; i++)
            {
                ds[i] = new SV();
                ds[i].MSSV = Temp[i].MSSV;
                ds[i].Name = Temp[i].Name;
                ds[i].DHT = Temp[i].DHT;
            }
            // }
        }
        public int TimKiem(SV s)
        {
            int i;
            for (i = 0; i < count; i++)
                if (ds[i].MSSV == s.MSSV) return i;
            return -1;
        }
        public void XoaSV(SV s)
        {
            int i = TimKiem(s);
            //Console.WriteLine("{0}", i);
            if (i != -1) XoaSV1(i + 1);

        }
        public void Insert(int index, SV s)
        {
            if (index <= 0 || index > this.count) return;
            SV[] Temp = new SV[count];
            index--;
            if (index == 0)
            {
                for (int i = 0; i < this.count; i++)
                {
                    Temp[i] = this.ds[i];
                }
                this.count++;
                this.ds = new SV[count];
                this.ds[0] = s;
                for (int i = 0; i < this.count - 1; i++)
                    this.ds[i + 1] = Temp[i];
            }
            else if (index == this.count - 1)
            {
                for (int i = 0; i < this.count; i++)
                {
                    Temp[i] = this.ds[i];
                }
                this.count++;
                this.ds = new SV[count];
                this.ds[count - 1] = s;
                for (int i = 0; i < this.count - 1; i++)
                    this.ds[i] = Temp[i];
            }
            else
            {
                int n = -1;
                Temp = new SV[count + 1];
                for (int i = 0; i < index; i++)
                {
                    n++;
                    Temp[n] = this.ds[i];
                }
                n++;
                Temp[n] = s;
                for (int i = index; i < this.count; i++)
                {
                    n++;
                    Temp[n] = this.ds[i];
                }
                this.count++;
                this.ds = new SV[count];
                for (int i = 0; i <= n; i++)
                {
                    this.ds[i] = Temp[i];
                }
            }
        }
        // sap xep theo DHT
        public void Sort()
        {
            SV temp = new SV();
            for (int i = 0; i < this.count - 1; i++)
                for (int j = i + 1; j < this.count; j++)
                    if (this.ds[i].DHT > this.ds[j].DHT)
                    {
                        temp = this.ds[i];
                        this.ds[i] = this.ds[j];
                        this.ds[j] = temp;
                    }
        }

        public int BinarySearch(SV s)
        {
            int l = 0;
            int r = this.count - 1;
            Sort();
            s.Show();
            while (r >= l)
            {
                int mid = (r + l) / 2;
                this.ds[mid].Show();
                if (this.ds[mid].MSSV == s.MSSV && this.ds[mid].Name == s.Name && this.ds[mid].DHT == s.DHT) return mid;
                if (this.ds[mid].DHT > s.DHT) r = mid - 1;
                //if (this.ds[mid].DHT < s.DHT)
                l = mid + 1;
            }
            return -1;
        }
        /*
        public int BinarySearch(SV s) { }
        public void Clear()
        public void Reverse()
        // sap xep theo DHT
        public void Sort()
        */
        public void Show()
        {
            int i;
            for (i = 0; i < this.count; i++)
            {
                ds[i].Show();
                Console.WriteLine();
            }

        }


    }
}

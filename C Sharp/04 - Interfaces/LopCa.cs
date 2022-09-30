using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Interfaces
{
    public class LopCa : IBoi
    {
        public string ten_ca;
        public string mau_sac;
        public double can_nang;
        public bool co_vay;
        public LopCa(string ten_ca, string mau_sac, double can_nang, bool co_vay)
        {
            this.ten_ca = ten_ca;
            this.mau_sac = mau_sac;
            this.can_nang = can_nang;
            this.co_vay = co_vay;
        }
        public virtual void cachBoi()
        {
            Console.WriteLine("This is virtual void cachBoi of LopCa class");
        }
        public void info()
        {
            Console.WriteLine($"This is {ten_ca}.");
            Console.WriteLine($"Color: {mau_sac}");
            Console.WriteLine($"Weight: {can_nang}");
            if (co_vay)
                Console.WriteLine("This fish has fin");
            else
                Console.WriteLine("This fish doesn't have fin");
        }
    }
}

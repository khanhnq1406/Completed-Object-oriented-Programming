using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Interfaces
{
    public class CaChuon : LopCa, IBay
    {
        public double van_toc_bay;
        public CaChuon(string ten_ca, string mau_sac, double can_nang, bool co_vay, double van_toc_bay)
            : base(ten_ca, mau_sac, can_nang, co_vay)
        {
            this.van_toc_bay = van_toc_bay;
        }
        public override void cachBoi()
        {
            Console.WriteLine("This is virtual void cachBoi of CaChuon class");
        }
        public void cachBay()
        {
            Console.WriteLine("This is virtual void cachBay of CaChuon class");
        }
        public void info()
        {
            base.info();
            Console.WriteLine("Speed: {0} m/s", van_toc_bay);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Interfaces
{
    public class Ca7Mau : LopCa
    {
        public int so_mau;
        public Ca7Mau(string ten_ca, string mau_sac, double can_nang, bool co_vay, int so_mau)
            : base(ten_ca, mau_sac, can_nang, co_vay)
        {
            this.so_mau = so_mau;
        }
        public override void cachBoi()
        {
            Console.WriteLine("This is virtual void cachBoi of Ca7Mau class");
        }
        public void info()
        {
            base.info();
            Console.WriteLine("Number of color: ", so_mau);
        }
    }
}

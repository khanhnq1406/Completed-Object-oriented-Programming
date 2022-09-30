using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Interfaces
{
    public class CaTre : LopCa, IBo
    {
        public double toc_do_bo;
        public CaTre(string ten_ca, string mau_sac, double can_nang, bool co_vay,double toc_do_bo) 
            : base(ten_ca, mau_sac, can_nang, co_vay)
        {
            this.toc_do_bo = toc_do_bo;
        }
        public override void cachBoi()
        {
            Console.WriteLine("This is virtual void cachBoi of CaTre class");
        }
        public void cachBo()
        {
            Console.WriteLine("This is virtual void cachBo of CaTre class");
        }
        public void info()
        {
            base.info();
            Console.WriteLine("Speed: {0} m/s", toc_do_bo);
        }
    }
}

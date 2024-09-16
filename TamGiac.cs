using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan1
{
    class TamGiac: Hinh
    {
        private double canhA, canhB, canhC;
        public double CanhA { 
            get { return this.canhA; } 
            set { this.canhA = value; }
        }
        public double CanhB
        {
            get { return this.canhB; }
            set { this.canhB = value; }
        }
        public double CanhC
        {
            get { return this.canhC; }
            set { this.canhC = value; }
        }

        public TamGiac() : base()
        {
            
        }

        public void Nhap()
        {
            // base.Nhap();
            Console.WriteLine("Nhap ten tam giac: ");
            base.tenHinh = "Tam giac " + Console.ReadLine();
        }

        public override void Xuat()
        {
            //base.Nhap();
            Console.WriteLine("Tam giac ten " + base.tenHinh);
        }
    }
}

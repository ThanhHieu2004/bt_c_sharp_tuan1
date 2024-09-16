using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan1
{
    class HinhTron : Hinh // extends Hinh
    {
        private double r;
        private double R
        {
            get { return r; } // Write data
            set { this.r = value; } // Read data
        }

        public HinhTron() : base() // Empty Constructor
        {

        }

        public HinhTron(String th, double r): base(th) // Valued Constructor
        {
            this.r = r;
        }

        public double tinhChuVi()
        {
            return 2*Math.PI*this.r;
        }

        public double tinhDienTich()
        {
            return Math.Pow(2, this.r)*Math.PI;
        }

        public void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap ban hinh r: ");
            this.r = Convert.ToDouble(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Day la hinh tron " +  this.r + " cm");
        }
    }
}

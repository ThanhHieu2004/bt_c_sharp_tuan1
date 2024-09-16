using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan1
{
    internal class Hinh
    {
        protected String tenHinh; // Data field

        private String TenHinh // Properties
        {
            set { this.tenHinh = value; }
            get { return this.tenHinh; }
        }

        public Hinh()
        {

        }
        public Hinh(String tenHinh)
        {
            this.tenHinh = tenHinh;
        }


        public void Nhap()
        {
            Console.Write("Nhap ten hinh: ");
            this.tenHinh = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ten hinh " + this.tenHinh);
        }
    }
}

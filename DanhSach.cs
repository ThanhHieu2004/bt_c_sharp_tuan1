using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan1
{
    class DanhSach
    {
        private List<Hinh> list;
        public List<Int16> newIntList;
        public DanhSach()
        {
            list = new List<Hinh>();
        }

        public void Xuat()
        {
            foreach (Hinh h in list)
            {
                h.Xuat();
            }
        }


        // indexer
        public Hinh this[int index] { 
            get { if (index < list.Count()) return list[index]; else return null; }
            set { this.list.Add(value); }
        }

        // indexer - Not quite right
        /* public int this[int index]
        {
            get { if (index < list.Count()) return this[index]; else return null; }
            set { this.list.Add(value); }
        } */


        public void Nhap()
        {
            char c;
            Console.Write("Nhap 'G/g' cho tam giac, 'T/t' cho hinh tron. Any Key to exit.");
            c = char.Parse(Console.ReadLine().ToLower());
            while (c =='g' || c == 't')
            {
                if (c == 'g')
                {
                    Hinh tg = new TamGiac();
                    tg.Nhap();
                    list.Add(tg);
                }
                else
                    if (c == 't')
                {
                    Hinh tron = new HinhTron();
                    tron.Nhap();
                    list.Add(tron);
                }
                else
                    break;
                Console.Write("Nhap 'G/g' cho tam giac, 'T/t' cho hinh tron. Any Key to exit.");
                c = char.Parse(Console.ReadLine().ToLower());
            }
        }

        
    }
}

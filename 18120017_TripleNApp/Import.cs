using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class Import
    {
        IDGeneration IDGeneration = new IDGeneration();

        public string ma { get; set; }
        public string ten { get; set; }
        public string diachi { get; set; }
        public string link { get; set; }
        public double tongtien { get; set; }
        public int tongsanpham { get; set; }
        public bool yeuthich { get; set; }
        public bool cothongbao { get; set; }
        public string noidung { get; set; }
        public DateTime thoigian { get; set; }

        public Import()
        {
            ma = IDGeneration.RandomID();
            cothongbao = false;
            yeuthich = false;
            tongtien = 0;
            tongsanpham = 0;
        }
    }
    

}

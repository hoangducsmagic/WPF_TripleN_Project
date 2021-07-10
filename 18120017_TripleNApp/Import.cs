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
        public double tongsanpham { get; set; }
        bool yeuthich;

        public Import()
        {
            ma = IDGeneration.RandomID();
            yeuthich = false;
            tongtien = 0;
            tongsanpham = 0;
        }
    }
    

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class Customer
    {
        public string ma { get; set; }
        public string ten { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public int solan { get; set; }
        public double tongtien { get; set; }

        public Customer()
        {
            ma = IDGeneration.RandomID();
        }
    }
}

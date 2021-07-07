using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class Bill
    {
       
        public string ma { get; set; }
        public string makhachhang { get; set; }
        public string tenkhachhang { get; set; }
        public DateTime ngaylap { get; set; }
        public double vanchuyen { get; set; }
        public double thanhtien { get; set; }
        public List<ProductInBill> ProductList { get; set; } 

        public Bill()
        {
            thanhtien = 0;
        }

    }
}

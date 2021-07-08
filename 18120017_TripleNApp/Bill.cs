using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class Bill
    {
        public Customer khachhang { get; set; }
        
        public string ma { get; set; }
        public DateTime ngaylap { get; set; }
        public double vanchuyen { get; set; }
        public double thanhtien { get; set; }
        public List<ProductInBill> ProductList { get; set; } 
        public List<Discount> DiscountList { get; set; }

        IDGeneration IDGeneration = new IDGeneration();
        public Bill()

        {
            vanchuyen = 0;
            thanhtien = 0;
            ma = IDGeneration.RandomID();
        }

    }
}

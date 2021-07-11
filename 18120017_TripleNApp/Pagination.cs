using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class Pagination
    {
        public static int CurrentPage { get; set; } 
        public int ProductPerPage { get; set; } = Int32.Parse(ConfigurationManager.AppSettings["ProductPerPage"]);
        public int TotalProduct { get; set; }
        public int TotalPage { get; set; }

        public void update(int totalproduct)
        {
            TotalProduct = totalproduct;
            TotalPage = totalproduct / ProductPerPage + (totalproduct % ProductPerPage != 0?1:0);
        }

        public int take()
        {
            return ProductPerPage; 
        }

        public int skip()
        {
            return (CurrentPage - 1) * ProductPerPage;
        }
        
    }
}

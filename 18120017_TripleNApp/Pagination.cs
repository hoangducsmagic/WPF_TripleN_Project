using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class Pagination
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public static int CurrentPage { get; set; } 
        public int ProductPerPage { get; set; } 
        public int TotalProduct { get; set; }
        public int TotalPage { get; set; }

        public Pagination()
        {
            ProductPerPage = Int32.Parse(config.AppSettings.Settings["ProductPerPage"].Value);
        
            
        }

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

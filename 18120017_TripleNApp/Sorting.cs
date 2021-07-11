using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class Sorting
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public int ProductSortBy { get; set; }
        //1. theo tên   2. theo giá bán    3. theo đã bán      4. theo tồn kho
        
        public int ProductOrder { get; set; }
        //1. tăng dần   2. giảm dần
       
        public int BillSortBy { get; set; }
        //1. theo tên khách hàng    //2. theo tổng tiền     3. theo ngày
        
        public int BillOrder { get; set; } 
        
        public int SourceSortBy { get; set; } 
        //1. theo tên   2. theo tiền nhập   3. theo yêu thích
        
        public int SourceOrder { get; set; } 
    
        public Sorting()
        {
            ProductSortBy = Int32.Parse(config.AppSettings.Settings["ProductSortBy"].Value);
            ProductOrder = Int32.Parse(config.AppSettings.Settings["ProductOrder"].Value);
            BillSortBy = Int32.Parse(config.AppSettings.Settings["BillSortBy"].Value);
            BillOrder = Int32.Parse(config.AppSettings.Settings["BillOrder"].Value);
            SourceSortBy = Int32.Parse(config.AppSettings.Settings["SourceSortBy"].Value);
            SourceOrder = Int32.Parse(config.AppSettings.Settings["SourceOrder"].Value);
        }

        public List<Product> ProductSort(List<Product> ProductList)
        {
            switch (ProductSortBy)
            {
                case 1: 
                    if (ProductOrder == 1) 
                        ProductList= ProductList.OrderBy(c => c.ten).ToList(); 
                    else 
                        ProductList= ProductList.OrderByDescending(c => c.ten).ToList(); 
                    break;

                case 2:
                    if (ProductOrder == 1)
                        ProductList = ProductList.OrderBy(c => c.giaban).ToList();
                    else
                        ProductList = ProductList.OrderByDescending(c => c.giaban).ToList();
                    break;

                case 3:
                    if (ProductOrder == 1)
                        ProductList = ProductList.OrderBy(c => c.daban).ToList();
                    else
                        ProductList = ProductList.OrderByDescending(c => c.daban).ToList();
                    break;

                case 4:
                    if (ProductOrder == 1)
                        ProductList = ProductList.OrderBy(c => c.tonkho).ToList();
                    else
                        ProductList = ProductList.OrderByDescending(c => c.tonkho).ToList();
                    break;
            }

            return ProductList;
        }

        public List<Bill> BillSort(List<Bill> BillList)
        {
            switch (BillSortBy)
            {
                case 1:
                    if (BillOrder == 1)
                        BillList = BillList.OrderBy(c => c.khachhang.ten).ToList();
                    else
                        BillList = BillList.OrderByDescending(c => c.khachhang.ten).ToList();
                    break;

                case 2:
                    if (BillOrder == 1)
                        BillList = BillList.OrderBy(c => c.thanhtien).ToList();
                    else
                        BillList = BillList.OrderByDescending(c => c.thanhtien).ToList();
                    break;

                case 3:
                    if (BillOrder == 1)
                        BillList = BillList.OrderBy(c => c.ngaylap).ToList();
                    else
                        BillList = BillList.OrderByDescending(c => c.ngaylap).ToList();
                    break;

            }

            return BillList;
        }

        public List<Import> SourceSort(List<Import> SourceList)
        {
            switch (SourceSortBy)
            {
                case 1:
                    if (SourceOrder == 1)
                        SourceList = SourceList.OrderBy(c => c.ten).ToList();
                    else
                        SourceList = SourceList.OrderByDescending(c => c.ten).ToList();
                    break;

                case 2:
                    if (SourceOrder == 1)
                        SourceList = SourceList.OrderBy(c => c.tongtien).ToList();
                    else
                        SourceList = SourceList.OrderByDescending(c => c.tongtien).ToList();
                    break;

                case 3:
                    if (SourceOrder == 1)
                        SourceList = SourceList.OrderBy(c => c.yeuthich).ToList();
                    else
                        SourceList = SourceList.OrderByDescending(c => c.yeuthich).ToList();
                    break;

            }

            return SourceList;
        }

    }
}

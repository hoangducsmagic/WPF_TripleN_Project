using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class BillBUS
    {
        Random rng = new Random();
        BillDAO BillDAO = new BillDAO();
        TripleNDatabaseEntities db = new TripleNDatabaseEntities();
        IDGeneration IDGeneration = new IDGeneration();
        CustomerDAO CustomerDAO = new CustomerDAO();

        public string RandomID()
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second.ToString();
            char letter = (char)(rng.Next(90 - 65 + 1) + 65);
            return $"{day}{hour}{month}{letter}{minute}{year}{second}";
        }

        public List<Discount> GetDiscountList(List<ProductInBill> BuyList,Customer khachhang, DateTime ngaylap, double vanchuyen)
        {
            
            List<Discount> DisList = new List<Discount>();

            var typequery = from c in BuyList
                            select c.masanpham.Distinct();
            double billvalue = BuyList.Sum(c => c.thanhtien);

            if (typequery.Count() >= 5) // 5 loại sản phẩm giảm 10%
            {
                DisList.Add(new Discount() { ten = "Mua 5 loại sản phẩm khác nhau - giảm 10%", sotien = billvalue * 0.1 });
            } else // 3 sản phẩm giảm  5%
            {
                var sumproduct = BuyList.Sum(c => c.soluong);
                if (sumproduct >= 3)
                    DisList.Add(new Discount() { ten = "Mua 3 sản phẩm - giảm 5%", sotien = billvalue * 0.05 });
            }

            if (khachhang != null)
            {
                if ((khachhang.solan % 5) == 4)
                    DisList.Add(new Discount() { ten = "Tri ân khách hàng thân thiết - tặng đồ bất kỳ", sotien = 0 });
            }
            if (billvalue >= 70000 && ngaylap.Month == 4)
                DisList.Add(new Discount() { ten="Đơn hàng trên  70k đặt vào tháng 4 - freeship",sotien=vanchuyen});

            return DisList;
        }

        public string BillAdd(Bill Bill)
        {
            var idquery = db.DONHANG.Find(Bill.ma);
            if (idquery != null) return "Mã đơn bị trùng";
            if (Bill.vanchuyen < 0) return "Phí vận chuyển không hợp lệ";

            // kiểm tra quá số lượng tồn kho
            foreach(var item in Bill.ProductList)
            {
                var tonkho = db.SANPHAM.Find(item.masanpham).SoLuongTonKho;
                if (Bill.ProductList.Where(c => c.masanpham == item.masanpham).Sum(c => c.soluong) > tonkho)
                    return $"Sản phẩm {item.tensanpham} vượt quá số lượng tồn kho!"; 
            }

            Bill.thanhtien = Bill.ProductList.Sum(c => c.thanhtien) + Bill.vanchuyen;
            Bill.thanhtien -= Bill.DiscountList.Sum(c => c.sotien);
            Bill.thanhtien = Math.Max(Bill.thanhtien, 0);
            BillDAO.BillAdd(Bill);
            return "";
        }

        public void BillDelete(Bill Bill)
        {
            BillDAO.BillDelete(Bill);
        }
    }
}

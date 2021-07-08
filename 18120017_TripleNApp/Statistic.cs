using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class Statistic
    {
        TripleNDatabaseEntities db = new TripleNDatabaseEntities();

        public class columnstat
        {
            public int thang;
            public double thanhtien;
        }

        public class piestat
        {
            public string tensanpham;
            public double tongtien;
        }

        public List<int> GetYearList()
        {
            List<int> YearList = new List<int>();
            var yearquery = from c in db.DONHANG
                            group c by ((DateTime)c.ThoiGian).Year into g
                            select g.Key;
            foreach (var item in yearquery) YearList.Add(item);
            return YearList;
        }

        public List<piestat> GetProductStat(int  month, int year)
        {
            List<piestat> ColStat = new List<piestat>();
           var query = from c in db.CHITIETDATHANG
                         join d in db.SANPHAM on c.MaSanPham equals d.MaSanPham
                         join t in db.DONHANG on c.MaDonHang equals t.MaDon
                         where ((DateTime)t.ThoiGian).Year == year
                         where ((DateTime)t.ThoiGian).Month == month
                         group c by c.MaSanPham into g
                         select new { soluong = g.Sum(x => x.SoLuong), key = g.Key };
            
           
            foreach(var item   in query)
            {
                var product= db.SANPHAM.Find(item.key);
                ColStat.Add(new piestat() { tensanpham = product.TenSanPham, tongtien = (double)product.GiaBan *(int)item.soluong });
            }
            return ColStat;
        }

        public List<columnstat> GetTotalStat(int year)
        {
            List<columnstat>  StatList=new List<columnstat>();

            var query = from c in db.DONHANG
                        where ((DateTime)c.ThoiGian).Year == year
                        group c by ((DateTime)c.ThoiGian).Month into g
                        select new { thang = g.Key, thanhtien = g.Sum(x => x.ThanhTien) };

            foreach (var item in query)
                StatList.Add(new columnstat() { thang=item.thang,thanhtien=(double)item.thanhtien});
            return StatList;
        }
    }
}

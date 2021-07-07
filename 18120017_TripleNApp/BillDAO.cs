using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class BillDAO
    {
        TripleNDatabaseEntities db = new TripleNDatabaseEntities();
        

        public List<Bill> GetBillData()
        {
            List<Bill> BillList = new List<Bill>();
            var query = from c in db.DONHANG
                        join d in db.KHACHHANG on c.MaKhachHang equals d.MaKhachHang
                        select (new { MaDon = c.MaDon, MaKhachHang = c.MaKhachHang, TenKhachHang = d.HoTen, NgayLap = c.ThoiGian, ThanhTien = c.ThanhTien,VanChuyen=c.PhiVanChuyen });
            foreach(var item in query)
            {
                BillList.Add(new Bill() { ma = item.MaDon, makhachhang = item.MaKhachHang, tenkhachhang = item.TenKhachHang, ngaylap = (DateTime)item.NgayLap, thanhtien = (double)item.ThanhTien, vanchuyen = (double)item.VanChuyen });
            }
            return BillList;
        }
    }
}

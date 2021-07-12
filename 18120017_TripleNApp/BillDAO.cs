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

        public Bill GetBillData(string ID)
        {
            var query = db.DONHANG.Find(ID);
            Bill Bill = new Bill() {ma=ID,ngaylap=(DateTime)query.ThoiGian,thanhtien=(double)query.ThanhTien,vanchuyen=(double)query.PhiVanChuyen};
            
            var customerquery = db.KHACHHANG.Find(query.MaKhachHang);
            Customer Customer = new Customer() { ma = customerquery.MaKhachHang, diachi = customerquery.DiaChi, sdt = customerquery.SoDienThoai, solan = (int)customerquery.SoLanDatHang, ten = customerquery.HoTen, tongtien = (double)customerquery.TongTienDatHang };
            Bill.khachhang = Customer;

            var buyquery = from c in db.CHITIETDATHANG
                           join d in db.SANPHAM on c.MaSanPham equals d.MaSanPham
                           where c.MaDonHang == ID
                           select (new { c, d });
            List<ProductInBill> ProductList = new List<ProductInBill>();
            foreach (var item in buyquery)
                ProductList.Add(new ProductInBill() { dongia=(double)item.d.GiaBan,masanpham=item.c.MaSanPham,soluong=(int)item.c.SoLuong,tensanpham=item.d.TenSanPham,thanhtien=(int)item.c.SoLuong*(double)item.d.GiaBan});
            Bill.ProductList = ProductList;

            var disquery = from c in db.KHUYENMAI
                           where c.MaDon == ID
                           select c;
            List<Discount> DiscountList = new List<Discount>();
            foreach (var item in disquery)
                DiscountList.Add(new Discount() {sotien=(double)item.TienKhuyenMai,ten=item.TenKhuyenMai});
            Bill.DiscountList = DiscountList;
            
            return Bill;
        }

        public List<Bill> GetBillData()
        {
            List<Bill> BillList = new List<Bill>();
            var query = from c in db.DONHANG
                        join d in db.KHACHHANG on c.MaKhachHang equals d.MaKhachHang
                        select (new { MaDon = c.MaDon, MaKhachHang = c.MaKhachHang, TenKhachHang = d.HoTen, NgayLap = c.ThoiGian, ThanhTien = c.ThanhTien,VanChuyen=c.PhiVanChuyen });
            foreach(var item in query)
            {
                
                BillList.Add(new Bill() { khachhang=new Customer() { ma = item.MaKhachHang, ten = item.TenKhachHang }, ma = item.MaDon,  ngaylap = (DateTime)item.NgayLap, thanhtien = (double)item.ThanhTien, vanchuyen = (double)item.VanChuyen });
            }
            return BillList;
        }

        public void BillAdd(Bill Bill)
        {
            // Kiểm tra khách hàng
            var customerqquery = from c in db.KHACHHANG
                              where c.HoTen == Bill.khachhang.ten
                              where c.SoDienThoai == Bill.khachhang.sdt
                              select c;
            var oldcustomer = (customerqquery.Count() == 0 ? null : customerqquery.FirstOrDefault());    
            if (oldcustomer == null)
            {
                Bill.khachhang.ma = IDGeneration.RandomID();
                db.KHACHHANG.Add(new KHACHHANG() { HoTen = Bill.khachhang.ten, DiaChi = Bill.khachhang.diachi, MaKhachHang = Bill.khachhang.ma, SoDienThoai = Bill.khachhang.sdt, SoLanDatHang = 1, TongTienDatHang = Bill.thanhtien });
            }  else 
            {
                Bill.khachhang.ma = oldcustomer.MaKhachHang;
                oldcustomer.SoLanDatHang++;
                oldcustomer.TongTienDatHang += Bill.thanhtien;
                oldcustomer.DiaChi = Bill.khachhang.diachi;
            }

            // Chi tiết đơn hàng
            foreach (var item in Bill.ProductList)
            {
                var product = db.SANPHAM.Find(item.masanpham);
                product.SoLuongTonKho -= item.soluong;
                product.SoLuongDaBan += item.soluong;
                db.CHITIETDATHANG.Add(new CHITIETDATHANG() { MaDonHang = Bill.ma, MaSanPham = item.masanpham, SoLuong = item.soluong });
            }
            //  Khuyến mãi
            foreach (var item in Bill.DiscountList)
                db.KHUYENMAI.Add(new KHUYENMAI() { MaDon = Bill.ma, TenKhuyenMai = item.ten, TienKhuyenMai = item.sotien });

            db.DONHANG.Add(new DONHANG() {MaDon=Bill.ma,MaKhachHang=Bill.khachhang.ma,PhiVanChuyen=Bill.vanchuyen,ThanhTien=Bill.thanhtien,ThoiGian=Bill.ngaylap });
            db.SaveChanges();
        }

        public void BillDelete(Bill Bill)
        {
            var customer = db.KHACHHANG.Find(Bill.khachhang.ma);
            if (customer.SoLanDatHang == 1)
            {
                db.KHACHHANG.Remove(customer);
            } else
            {
                customer.SoLanDatHang--;
                customer.TongTienDatHang -= Bill.thanhtien;
            }

            var discountquery = from c in db.KHUYENMAI
                                where c.MaDon == Bill.ma
                                select c;
            foreach (var item in discountquery) db.KHUYENMAI.Remove(item);

            var query = from c in db.CHITIETDATHANG
                        where c.MaDonHang == Bill.ma
                        select c;
            foreach (var item in query) db.CHITIETDATHANG.Remove(item);

            var billitem = db.DONHANG.Find(Bill.ma);
            db.DONHANG.Remove(billitem);

            db.SaveChanges();
        }

    }
}

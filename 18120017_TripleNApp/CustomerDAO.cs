using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class CustomerDAO
    {
        
        TripleNDatabaseEntities db = new TripleNDatabaseEntities();
        public List<Customer> GetCustomerData()
        {
            List<Customer> MemList = new List<Customer>();
            var query = from c in db.KHACHHANG
                        select c;
            foreach (var item in query)
                MemList.Add(new Customer() { ma = item.MaKhachHang, diachi = item.DiaChi, sdt = item.SoDienThoai, solan = (int)item.SoLanDatHang, ten = item.HoTen, tongtien = (double)item.TongTienDatHang });
            return MemList;
        }    
        
        public Customer FindCustomer(string ID)
        {
            var query = db.KHACHHANG.Find(ID);
            Customer khachhang = new Customer() { diachi=query.DiaChi,ma=query.MaKhachHang,sdt=query.SoDienThoai,solan=(int)query.SoLanDatHang,ten=query.HoTen,tongtien=(double)query.TongTienDatHang};
            return khachhang;
        }

        public Customer FindCustomer(string ten,string sdt)
        {
            var query = from c in db.KHACHHANG
                        where c.HoTen == ten
                        where c.SoDienThoai == sdt
                        select c;
            if (query.Count() > 0)
            {
                Customer khachhang = new Customer() { diachi = query.FirstOrDefault().DiaChi, ma = query.FirstOrDefault().MaKhachHang, sdt = query.FirstOrDefault().SoDienThoai, solan = (int)query.FirstOrDefault().SoLanDatHang, ten = query.FirstOrDefault().HoTen, tongtien = (double)query.FirstOrDefault().TongTienDatHang };
                return khachhang;
            }
            return null;
        }

        public void AddCustomer(Customer customer)
        {
            db.KHACHHANG.Add(new KHACHHANG() {DiaChi=customer.diachi,HoTen=customer.ten,MaKhachHang=customer.ma,SoDienThoai=customer.sdt,SoLanDatHang=customer.solan,TongTienDatHang=customer.tongtien });
            db.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class CustomerDAO
    {
        List<Customer> MemList = new List<Customer>();
        TripleNDatabaseEntities db = new TripleNDatabaseEntities();
        public List<Customer> GetCustomerData()
        {
            var query = from c in db.KHACHHANG
                        select c;
            foreach (var item in query)
                MemList.Add(new Customer() { ma = item.MaKhachHang, diachi = item.DiaChi, sdt = item.SoDienThoai, solan = (int)item.SoLanDatHang, ten = item.HoTen, tongtien = (double)item.TongTienDatHang });
            return MemList;
        }    
        
        public Customer FindCustomer(string ID)
        {
            return MemList.Find(c => c.ma == ID);
        }
    }
}

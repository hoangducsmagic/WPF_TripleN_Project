using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class ProductDAO
    {
        public TripleNDatabaseEntities db = new TripleNDatabaseEntities();

        public List<Product> GetProductData()
        {
            List<Product> ProductList = new List<Product>();
            var productquery = from c in db.SANPHAM
                        select c;
            foreach(var item in productquery)
            {
                List<Color> mausac = new List<Color>();
                List<Pic> hinhanh = new List<Pic>();
                List<Size> kichthuoc = new List<Size>();

                var colorquery = from c in db.MAUSACSANPHAM
                                 where c.MaSanPham == item.MaSanPham
                                 select(c.MauSac);
                foreach (var item2 in colorquery) mausac.Add(new Color() { color = item2 });
               

                var sizequery = from c in db.KICHTHUOCSANPHAM
                                 where c.MaSanPham == item.MaSanPham
                                 select (c.KichThuoc);
                foreach (var item2 in sizequery) kichthuoc.Add(new Size() { size = item2 });
               

                var imagequery = from c in db.HINHANHSANPHAM
                                 where c.MaSanPham == item.MaSanPham
                                 select (c.HinhAnh);
                foreach (var item2 in imagequery) hinhanh.Add(new Pic() { pic = item2 });
                
                string tenloai = db.LOAISANPHAM.Find(item.MaLoai).TenLoai;
                ProductList.Add(new Product() { avt = hinhanh.ElementAtOrDefault(0).pic, ma = item.MaSanPham, ten = item.TenSanPham, tenloai=tenloai, maloai = item.MaLoai, daban = (int)item.SoLuongDaBan, tonkho = (int)item.SoLuongTonKho, giaban = (double)item.GiaBan, gianhap = (double)item.GiaNhap, hinhanh = hinhanh, mausac = mausac, kichthuoc = kichthuoc, manguon = item.MaNguon, mota = item.MoTa, phantram = (double)item.PhanTramChi, toithieu = (int)item.SoLuongToiThieu, trongluong = (double)item.TrongLuong, nhapthem = (item.SoLuongTonKho < item.SoLuongToiThieu) });
                
            }
            return ProductList;
        }

        public List<ProductType> GetTypeData()
        {
            List<ProductType> TypeList = new List<ProductType>();
            var typequery = from c in db.LOAISANPHAM
                            select c;
            foreach(var item in typequery)
            {
                var productquery = from c in db.SANPHAM
                                   where c.MaLoai == item.MaLoai
                                   select c;
                List<Product> ProductList = new List<Product>();
                foreach (var item2 in productquery)
                    ProductList.Add(new Product() { ma = item2.MaSanPham, ten = item2.TenSanPham });
                TypeList.Add(new ProductType() { ma = item.MaLoai, ten = item.TenLoai, soluong = ProductList.Count(), ProductList = ProductList });
                
            }
            return TypeList;
        }

        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class ProductDAO
    {
        TripleNDatabaseEntities db = new TripleNDatabaseEntities();

        public List<Product> GetProductData()
        {
            List<Product> ProductList = new List<Product>();
            var productquery = from c in db.SANPHAM
                        select c;
            foreach(var item in productquery)
            {
                List<string> mausac = new List<string>();
                List<string> hinhanh = new List<string>();
                List<string> kichthuoc = new List<string>();

                var colorquery = from c in db.MAUSACSANPHAM
                                 where c.MaSanPham == item.MaSanPham
                                 select(c.MauSac);
                mausac = colorquery.ToList();

                var sizequery = from c in db.KICHTHUOCSANPHAM
                                 where c.MaSanPham == item.MaSanPham
                                 select (c.KichThuoc);
                kichthuoc = sizequery.ToList();

                var imagequery = from c in db.HINHANHSANPHAM
                                 where c.MaSanPham == item.MaSanPham
                                 select (c.HinhAnh);
                hinhanh = imagequery.ToList();

                ProductList.Add(new Product() { avt=hinhanh.ElementAtOrDefault(0), ma = item.MaSanPham, ten = item.TenSanPham, maloai = item.MaLoai, daban = (int)item.SoLuongDaBan, tonkho = (int)item.SoLuongTonKho, giaban = (double)item.GiaBan, gianhap = (double)item.GiaNhap, hinhanh = hinhanh, mausac = mausac, kichthuoc = kichthuoc, manguon = item.MaNguon, mota = item.MoTa, phantram = (double)item.PhanTramChi, toithieu = (int)item.SoLuongToiThieu, trongluong = (double)item.TrongLuong, nhapthem=(item.SoLuongTonKho<item.SoLuongToiThieu) });
                
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

using System;
using System.Collections.Generic;
using System.IO;
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

                string currentFolder = AppDomain.CurrentDomain.BaseDirectory;
                var imagequery = from c in db.HINHANHSANPHAM
                                 where c.MaSanPham == item.MaSanPham
                                 select (c.HinhAnh);
                foreach (var item2 in imagequery) hinhanh.Add(new Pic() { pic = item2,path= $"{currentFolder}ImagesResource\\{item2}" });
                
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

        public List<ProductType> GetTypeData2()
        {
            List<ProductType> TypeList = new List<ProductType>();
            var typequery = from c in db.LOAISANPHAM
                            select c;

            foreach(var item in typequery)
            {
                TypeList.Add(new ProductType() { ma = item.MaLoai, ten = item.TenLoai });

            }
            return TypeList;
        }

        public List<ProductSource> GetSourceData()
        {
            List<ProductSource> SourceList = new List<ProductSource>();
            var query = from c in db.NGUONNHAP
                        select c;
            foreach (var item in query)
                SourceList.Add(new ProductSource() { ten = item.TenNguon, ma = item.MaNguon });
            return SourceList;

        }

        public void ProductAdd(Product product)
        {
            // Thêm loại
            var typeexist = db.LOAISANPHAM.Find(product.maloai);
            if (typeexist == null)
                db.LOAISANPHAM.Add(new LOAISANPHAM() { MaLoai = product.maloai, TenLoai = product.tenloai });
            
            // Copy ảnh vào thư mục nội bộ
            string newName, newItem;
            string currentFolder = AppDomain.CurrentDomain.BaseDirectory;
            foreach (var item in product.hinhanh)
            {
                var info = new FileInfo(item.path);
                newName = $"{Guid.NewGuid()}{info.Extension}";
                newItem = $"{currentFolder}ImagesResource\\{newName}";
                File.Copy(item.path, newItem);
                item.pic = newName;
                db.HINHANHSANPHAM.Add(new HINHANHSANPHAM() { HinhAnh = item.pic, MaSanPham = product.ma });
            }

            // Thêm màu sắc
            foreach (var item in product.mausac)
                db.MAUSACSANPHAM.Add(new MAUSACSANPHAM() { MaSanPham = product.ma, MauSac = item.color });

            // Thêm kích thước
            foreach (var item in product.kichthuoc)
                db.KICHTHUOCSANPHAM.Add(new KICHTHUOCSANPHAM() { KichThuoc = item.size, MaSanPham = product.ma });

            db.SANPHAM.Add(new SANPHAM() { MaSanPham = product.ma, MaLoai = product.maloai, GiaBan = product.giaban, GiaNhap = product.gianhap, MaNguon = product.manguon, MoTa = product.mota, PhanTramChi = product.phantram, SoLuongDaBan = product.daban, SoLuongTonKho = product.tonkho, SoLuongToiThieu = product.toithieu, TenSanPham = product.ten, TrongLuong = product.trongluong });
            db.SaveChanges();
        }
        
        public void ProductUpdate(Product product)
        {
            
        }
    }
}

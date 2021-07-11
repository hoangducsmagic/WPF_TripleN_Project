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

        public Product FindProduct(string ID)
        {
            
            var item = db.SANPHAM.Find(ID);
            List<Color> mausac = new List<Color>();
            List<Pic> hinhanh = new List<Pic>();
            List<Size> kichthuoc = new List<Size>();

            var colorquery = from c in db.MAUSACSANPHAM
                             where c.MaSanPham == item.MaSanPham
                             select (c.MauSac);
            foreach (var item2 in colorquery) mausac.Add(new Color() { color = item2 });


            var sizequery = from c in db.KICHTHUOCSANPHAM
                            where c.MaSanPham == item.MaSanPham
                            select (c.KichThuoc);
            foreach (var item2 in sizequery) kichthuoc.Add(new Size() { size = item2 });

            string currentFolder = AppDomain.CurrentDomain.BaseDirectory;
            var imagequery = from c in db.HINHANHSANPHAM
                             where c.MaSanPham == item.MaSanPham
                             select (c.HinhAnh);
            foreach (var item2 in imagequery) hinhanh.Add(new Pic() { pic = item2, path = $"{currentFolder}ImagesResource\\{item2}" });

            string tenloai = db.LOAISANPHAM.Find(item.MaLoai).TenLoai;
            Product Product=new Product() { avt = hinhanh.ElementAtOrDefault(0).pic, ma = item.MaSanPham, ten = item.TenSanPham, tenloai = tenloai, maloai = item.MaLoai, daban = (int)item.SoLuongDaBan, tonkho = (int)item.SoLuongTonKho, giaban = (double)item.GiaBan, gianhap = (double)item.GiaNhap, hinhanh = hinhanh, mausac = mausac, kichthuoc = kichthuoc, manguon = item.MaNguon, mota = item.MoTa, phantram = (double)item.PhanTramChi, toithieu = (int)item.SoLuongToiThieu, trongluong = (double)item.TrongLuong, nhapthem = (item.SoLuongTonKho < item.SoLuongToiThieu) };

            return Product;
        }

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
        
        public void ProductUpdate(Product newitem)
        {
            var olditem = db.SANPHAM.Find(newitem.ma);

            // cập nhật loại
            if (olditem.MaLoai != newitem.maloai)
            {
                var oldtype = from c in db.SANPHAM
                              where c.MaLoai == olditem.MaLoai
                              select c;
                if (oldtype.Count() == 1)   // xóa loại cũ
                {
                    var item = db.LOAISANPHAM.Find(oldtype.FirstOrDefault().MaLoai);
                    db.LOAISANPHAM.Remove(item);
                }
                var typeexist = db.LOAISANPHAM.Find(newitem.maloai);
                if (typeexist == null)  //  thêm loại mới
                    db.LOAISANPHAM.Add(new LOAISANPHAM() { MaLoai = newitem.maloai, TenLoai = newitem.tenloai });
            }


            // cập nhật hình ảnh
            string newName, newItem;
            string currentFolder = AppDomain.CurrentDomain.BaseDirectory;
            List<Pic> OldPicList = new List<Pic>();
            var oldpicquery = from c in db.HINHANHSANPHAM
                              where c.MaSanPham == newitem.ma
                              select c;
            foreach (var item in oldpicquery)
            {
                OldPicList.Add(new Pic() { pic = item.HinhAnh,path= $"{currentFolder}ImagesResource\\{item.HinhAnh}" });
            }

            // 1. Thêm ảnh mới
            foreach (var item in newitem.hinhanh) if (OldPicList.FindAll(c => c.pic == item.pic).Count() == 0)
                {
                    var info = new FileInfo(item.path);
                    newName = $"{Guid.NewGuid()}{info.Extension}";
                    newItem = $"{currentFolder}ImagesResource\\{newName}";
                    File.Copy(item.path, newItem);
                    item.pic = newName;
                    db.HINHANHSANPHAM.Add(new HINHANHSANPHAM() { HinhAnh = item.pic, MaSanPham = newitem.ma });
                }

            // 2. Xóa ảnh không dùng
            foreach (var item in OldPicList) if (newitem.hinhanh.FindAll(c => c.pic == item.pic).Count() == 0)
                {
                    File.Delete(item.path);
                    var tam = new FileInfo(item.pic);
                    db.HINHANHSANPHAM.Remove(db.HINHANHSANPHAM.Where(c => c.MaSanPham == newitem.ma).Where(c => c.HinhAnh == item.pic).FirstOrDefault());
                }

            // cập nhật kích thước
            var oldsizelist = from c in db.KICHTHUOCSANPHAM
                              where c.MaSanPham == newitem.ma
                              select c;
            foreach (var item in oldsizelist) db.KICHTHUOCSANPHAM.Remove(item);

            foreach (var item in newitem.kichthuoc) db.KICHTHUOCSANPHAM.Add(new KICHTHUOCSANPHAM() { KichThuoc = item.size, MaSanPham = newitem.ma });

            // cập nhật màu sắc
            var oldcolorlist = from c in db.MAUSACSANPHAM
                               where c.MaSanPham == newitem.ma
                               select c;
            foreach (var item in oldcolorlist) db.MAUSACSANPHAM.Remove(item);

            foreach (var item in newitem.mausac) db.MAUSACSANPHAM.Add(new MAUSACSANPHAM() { MaSanPham = newitem.ma, MauSac = item.color });

            // cập thông tin chung
            olditem.TenSanPham = newitem.ten;
            olditem.MaLoai = newitem.maloai;
            olditem.MoTa = newitem.mota;
            olditem.TrongLuong = newitem.trongluong;
            olditem.SoLuongTonKho = newitem.tonkho;
            olditem.GiaNhap = newitem.gianhap;
            olditem.GiaBan = newitem.giaban;
            olditem.PhanTramChi = newitem.phantram;
            olditem.MaNguon = newitem.manguon;
            olditem.SoLuongToiThieu = newitem.toithieu;

            db.SaveChanges();
        }

        public void ProductDelete(Product product)
        {
            // Xóa loại
            var type = from c in db.SANPHAM
                          where c.MaLoai == product.maloai
                          select c;
            if (type.Count() == 1)   
            {
                var item = db.LOAISANPHAM.Find(type.FirstOrDefault().MaLoai);
                db.LOAISANPHAM.Remove(item);
            }

            // Xóa hình ảnh
            foreach (var item in product.hinhanh) 
                {
                    File.Delete(item.path);
                    db.HINHANHSANPHAM.Remove(db.HINHANHSANPHAM.Where(c => c.MaSanPham == product.ma).Where(c => c.HinhAnh == item.pic).FirstOrDefault());
                }

            // Xóa kích thước
            var oldsizelist = from c in db.KICHTHUOCSANPHAM
                              where c.MaSanPham == product.ma
                              select c;
            foreach (var item in oldsizelist) db.KICHTHUOCSANPHAM.Remove(item);

            // Xóa màu sắc
            var oldcolorlist = from c in db.MAUSACSANPHAM
                               where c.MaSanPham == product.ma
                               select c;
            foreach (var item in oldcolorlist) db.MAUSACSANPHAM.Remove(item);

            //Xóa trong chi tiết đơn hàng  - không cập nhật giá trị đơn hàng
            var billquery = from c in db.CHITIETDATHANG
                            where c.MaSanPham == product.ma
                            select c;
            foreach (var item in billquery) db.CHITIETDATHANG.Remove(item);

            // Xóa thông tin chung
            db.SANPHAM.Remove(db.SANPHAM.Where(c => c.MaSanPham == product.ma).FirstOrDefault());
            db.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class ImportDAO
    {
        TripleNDatabaseEntities db = new TripleNDatabaseEntities();

        public List<string> GetProductNameList(string SourceID)
        {
            List<string> ProductList = new List<string>();
            var query = from c in db.SANPHAM
                        where c.MaNguon == SourceID
                        select c.TenSanPham;
            return query.ToList();
        }

        public List<Import> GetSourceList()
        {
            List<Import> SourceList = new List<Import>();
            var query = from c in db.NGUONNHAP
                        select c;
            foreach (var item in query)
            {
                Import Source = new Import() { diachi = item.DiaChi, link = item.LinkNguon, ma = item.MaNguon, ten = item.TenNguon, tongsanpham = (int)item.TongSanPhamNhap, tongtien = (double)item.TongTienNhap,yeuthich=(bool)item.YeuThich };
                
                var anounquery = db.THONGBAONHAPHANG.Find(item.MaNguon);
                if (anounquery != null)
                {
                    Source.cothongbao = true;
                    Source.noidung = anounquery.NoiDung;
                    Source.thoigian = (DateTime)anounquery.ThoiGianThongBao;
                }
                else Source.cothongbao = false;
                SourceList.Add(Source);
            }
                return SourceList;
        }

        public void SourceAdd(Import Source)
        {
            db.NGUONNHAP.Add(new NGUONNHAP() { DiaChi = Source.diachi, LinkNguon = Source.link, MaNguon = Source.ma, TenNguon = Source.ten, TongSanPhamNhap = (int)Source.tongsanpham, TongTienNhap = (double)Source.tongtien, YeuThich = Source.yeuthich });
            db.SaveChanges();
        }

        public void SourceDelete(Import Source)
        {
            var anounquery = db.THONGBAONHAPHANG.Find(Source.ma);
            if (anounquery != null) db.THONGBAONHAPHANG.Remove(anounquery);

            var item = db.NGUONNHAP.Find(Source.ma);
            db.NGUONNHAP.Remove(item);
            db.SaveChanges();
        }

        public void SourceUpdate(Import Source)
        {
            var item = db.NGUONNHAP.Find(Source.ma);
            item.TenNguon = Source.ten;
            item.TongSanPhamNhap = Source.tongsanpham;
            item.TongTienNhap = Source.tongtien;
            item.YeuThich = Source.yeuthich;
            
            if (Source.cothongbao)
            {
                var query = db.THONGBAONHAPHANG.Find(Source.ma);
                if (query == null)
                {
                    db.THONGBAONHAPHANG.Add(new THONGBAONHAPHANG() { MaNguon=Source.ma,NoiDung=Source.noidung,ThoiGianThongBao=(DateTime)Source.thoigian});
                }
                else
                {
                    query.ThoiGianThongBao = Source.thoigian;
                    query.NoiDung = Source.noidung;
                }
            }
            else
            {
                var query = db.THONGBAONHAPHANG.Find(Source.ma);
                if (query != null) db.THONGBAONHAPHANG.Remove(query);
            }

            db.SaveChanges();
        }

        public List<Anoucement> GetAnounList()
        {
            List<Anoucement> AnounList = new List<Anoucement>();
            var query = from c in db.THONGBAONHAPHANG
                        join d in db.NGUONNHAP on c.MaNguon equals d.MaNguon
                        select new { c, d };
            foreach (var item in query)
                AnounList.Add(new Anoucement() { manguon = item.c.MaNguon, tennguon = item.d.TenNguon, noidung = item.c.NoiDung, thoigian = (DateTime)item.c.ThoiGianThongBao });
            return AnounList;
        }

        public void AnounDelete(string SourceID)
        {
            var anoun = db.THONGBAONHAPHANG.Find(SourceID);
            db.THONGBAONHAPHANG.Remove(anoun);
            db.SaveChanges();
        }
    }
}

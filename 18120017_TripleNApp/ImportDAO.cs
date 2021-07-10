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
                SourceList.Add(new Import() { diachi=item.DiaChi,link=item.LinkNguon,ma=item.MaNguon,ten=item.TenNguon,tongsanpham=(int)item.TongSanPhamNhap,tongtien=(double)item.TongTienNhap});
            return SourceList;
        }

        public void SourceAdd(Import Source)
        {
            db.NGUONNHAP.Add(new NGUONNHAP() { DiaChi = Source.diachi, LinkNguon = Source.link, MaNguon = Source.ma, TenNguon = Source.ten, TongSanPhamNhap = (int)Source.tongsanpham, TongTienNhap = (double)Source.tongtien, YeuThich = Source.yeuthich });
            db.SaveChanges();
        }

        public void SourceDelete(Import Source)
        {
            var item = db.NGUONNHAP.Find(Source.ma);
            db.NGUONNHAP.Remove(item);
            db.SaveChanges();
        }
    }
}

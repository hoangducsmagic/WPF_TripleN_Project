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

        public List<Import> GetSourceList()
        {
            List<Import> SourceList = new List<Import>();
            var query = from c in db.NGUONNHAP
                        select c;
            foreach (var item in query)
                SourceList.Add(new Import() { diachi=item.DiaChi,link=item.LinkNguon,ma=item.MaNguon,ten=item.TenNguon,tongsanpham=(int)item.TongSanPhamNhap,tongtien=(double)item.TongTienNhap});
            return SourceList;
        }
    }
}

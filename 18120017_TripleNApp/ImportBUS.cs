using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{

    
    public class ImportBUS
    {
        ImportDAO ImportDAO = new ImportDAO();
        TripleNDatabaseEntities db = new TripleNDatabaseEntities();

        public string SourceAdd(Import Source)
        {
            var idquery = db.NGUONNHAP.Find(Source.ma);
            if (idquery != null) return "Mã nguồn nhập bị trùng!";

            ImportDAO.SourceAdd(Source);
            return "";
        }

        public Tuple<int,string> SourceDelete(Import Source)
        {
            var productlist = ImportDAO.GetProductNameList(Source.ma);
            
            if (productlist.Count() > 0)
            {
                
                string namelist = "";
                foreach (var item in productlist) namelist += $"{item}; ";
                return Tuple.Create( productlist.Count(),namelist );
            }
            ImportDAO.SourceDelete(Source);
            return null;
        }

        public void SourceUpdate(Import Source)
        {
            ImportDAO.SourceUpdate(Source);
        }

        public void MakeAnouncement()
        {
            var today=DateTime.Now.Date;
            var AnounList = ImportDAO.GetAnounList();
            foreach(var item in AnounList) 
                if (item.thoigian == today)
                {
                    AnoucementDialog screen = new AnoucementDialog(item);
                    screen.ShowDialog();
                }
        }

        public void AnounDelete(string SourceID)
        {
            ImportDAO.AnounDelete(SourceID);
        }

        public void ChangeFavoriteStatus(Import Source)
        {
            if (Source.yeuthich) Source.yeuthich = false; else Source.yeuthich = true;
            ImportDAO.SourceUpdate(Source);
        }

        public void AddSourceStatic(string ID, int sosanpham, double sotien)
        {
            TripleNDatabaseEntities db = new TripleNDatabaseEntities();
            var item = db.NGUONNHAP.Find(ID);
            item.TongSanPhamNhap += sosanpham;
            item.TongTienNhap += sotien;
            db.SaveChanges();
        }
    }
}

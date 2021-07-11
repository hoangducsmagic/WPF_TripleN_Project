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
        

        public void SourceAdd(Import Source)
        {
            ImportDAO.SourceAdd(Source);
        }

        public Tuple<int,string> SourceDelete(Import Source)
        {
            var productlist = ImportDAO.GetProductNameList(Source.ma);
            
            if (productlist.Count() > 0)
            {
                
                string namelist = "";
                foreach (var item in productlist) namelist += $"{item};";
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
    }
}

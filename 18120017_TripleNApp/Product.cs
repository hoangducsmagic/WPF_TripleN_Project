using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class Product
    {
        public string ma { get; set; }
        public string ten { get; set; }
        public  string maloai { get; set; }
        public string tenloai { get; set; }
        public string mota { get; set; }
        public  double  trongluong { get; set; }
        public int daban { get; set; }
        public int tonkho { get; set; }
        public double gianhap { get; set; }
        public double  giaban { get; set; }
        public double phantram { get; set; }
        public string manguon { get; set; }
        public int toithieu { get; set; }
        public string avt { get; set; }
        public List<Color> mausac { get; set; }
        public List<Size> kichthuoc { get; set; }
        public List<Pic> hinhanh { get; set; }
        public bool nhapthem { get; set; }

        public string ImagePathConverter(string value)
        {
            string currentFolder = AppDomain.CurrentDomain.BaseDirectory;
            return $"{currentFolder}ImagesResource\\{value}";
        }
    }

   
}

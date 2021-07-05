using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    public class ProductBUS
    {
        ProductDAO ProductDAO = new ProductDAO();
        Random rng = new Random();

        public string RandomID()
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second.ToString();
            char letter = (char)(rng.Next(90 - 65 + 1) + 65);
            return $"{day}{hour}{month}{letter}{minute}{year}{second}";
        }

        public string ProductAdd(Product product)
        {
            if (product.tonkho <= 0) return "Số lượng tồn kho phải lớn hơn 0";
            if (product.toithieu < 0) return "Lượng hàng tối thiểu phải lớn hơn 0";
            if (product.giaban < 0) return "Giá bán sản phẩm phải không âm";
            if (product.gianhap < 0) return "Giá nhập sản phẩm phải không âm";

            ProductDAO.ProductAdd(product);
            return "OK";
        }

        public string ProductUpdate(Product product)
        {
            if (product.tonkho <= 0) return "Số lượng tồn kho phải lớn hơn 0";
            if (product.toithieu < 0) return "Lượng hàng tối thiểu phải lớn hơn 0";
            if (product.giaban < 0) return "Giá bán sản phẩm phải không âm";
            if (product.gianhap < 0) return "Giá nhập sản phẩm phải không âm";

            ProductDAO.ProductUpdate(product);
            return "OK";
        }

        public void ProductDelete(Product product)
        {
            ProductDAO.ProductDelete(product);
        }
    }
}

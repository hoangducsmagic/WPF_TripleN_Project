using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18120017_TripleNApp
{
    
    public class IDGeneration
    {
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
    }

    
}

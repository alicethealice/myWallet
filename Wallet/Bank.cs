using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
    public class Bank
    {
        public Hashtable course = new Hashtable();
        public Bank()
        {
            //RUB, USD, GBP
            course.Add("RUBUSD", 20);
            course.Add("RUBGPB", 16);
            course.Add("USDRUB", 60000);
            course.Add("USDGPB", 850);
            course.Add("GPBRUB", 70000);
            course.Add("GPBUSD", 1200);
            course.Add("EURRUB", 6000);
        }

        public int convert(int amount, string n1, string n2)
        {
            Random a = new Random();
            int rnd = a.Next(80, 120);
            int m1 = (int)course[n1 + n2];
            int some = m1 * (rnd / 100) * amount;
            return some / 1000;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
    public class MoneyPrinter
    {
        public void print(string operation, string course, string amount)
        {
            Console.WriteLine("# - " + operation + " - валюта: " + course + ", в количестве: " + amount);
        }
    }
}

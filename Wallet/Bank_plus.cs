using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
    public class Bank_plus: Bank
    {
        public int convert(int amount, string n1, string n2)
        {
            int rnd = 100;
            int m1 = (int)course[n1 + n2];
            int some = m1 * (rnd / 100) * amount;
            return some / 1000;
        }
    }
}

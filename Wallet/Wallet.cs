using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet
{
    public class Wallet
    {
       public Hashtable wallet = new Hashtable();
        Bank bank;
        public MoneyPrinter printer;

        public Wallet(Bank bank1, MoneyPrinter printer1){
            bank = bank1;
            printer = printer1;
        }
   
        public void addMoney(string course, int amount)
        {
            if (wallet[course] == null)
            {
                wallet.Add(course, amount);
            }
            else {
                wallet[course] = (int)wallet[course] + amount;
            }

            printer.print("Add", course, amount.ToString());
        }

        int remov(string course, int amount)
        {
            if ((int)wallet[course] < amount)
            {
                throw new System.OverflowException();
            }
            else
            {
                return (int)wallet[course] - amount;
            }
        }

        public void removeMoney(string course, int amount)
        {
            try
            {
                wallet[course] = remov(course, amount);

                if ((int)wallet[course] == 0) 
                    wallet.Remove(course);
            }
            catch(OverflowException e) {                    
            }
            printer.print("Remove", course, amount.ToString());
        }

        public int getMoney(string course)
        {
            if (wallet[course] != null)
            {
                return (int)wallet[course];
            }
            else return 0;
        }

        public int getCount() {
            return wallet.Count;
        }

        public string toString2()
        {
            string str = "";
            ICollection keys = wallet.Keys;
            foreach (string s in keys) {
                str = str + wallet[s].ToString() + " " + s + ",";
            }
           str=str.Substring(0, str.Length- 1);
            return str;
        }

        public int getTotalMoney(string course)
        {
            int total=0;
            ICollection keys = wallet.Keys;
            foreach(string s in keys)
            {
                if (s == course)
                {
                    total = total + (int)wallet[s];
                }
                else {
                    total = total + bank.convert((int)wallet[s], s, course);
                }
            }
            return total;
        }
    }   
}

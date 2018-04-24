using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wallet;

namespace Wallet
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_800()
        {
            Bank b = new Bank();
            MoneyPrinter_plus mp = new MoneyPrinter_plus();
            Wallet some = new Wallet(b, mp);
            some.addMoney("RUB", 800);
            string lol = "RUB";
            Assert.AreEqual(some.getMoney(lol), 800);

        }
        [TestMethod]
        public void Add_400_then_Add_1000_EQUAL_1400()
        {
            Bank b = new Bank();
            MoneyPrinter_plus mp = new MoneyPrinter_plus();
            Wallet some = new Wallet(b, mp);
            some.addMoney("RUB", 400);
            some.addMoney("RUB", 1000);
            Assert.AreEqual(some.getMoney("RUB"), 1400);

        }

        [TestMethod]
        public void Add_Two_Course()
        {
            Bank b = new Bank();
            MoneyPrinter_plus mp = new MoneyPrinter_plus();
            Wallet some = new Wallet(b, mp);
            some.addMoney("RUB", 400);
            some.addMoney("EUR", 1000);
            Assert.AreEqual(some.getCount(), 2);

        }
        [TestMethod]
        public void Add_then_watch_the_list()
        {
            Bank b = new Bank();
            MoneyPrinter_plus mp = new MoneyPrinter_plus();
            Wallet some = new Wallet(b, mp);
            some.addMoney("RUB", 400);
            some.addMoney("EUR", 1000);
            Assert.AreEqual(some.toString2(), "400 RUB,1000 EUR");

        }
        [TestMethod]
        public void Test_Converter()
        {
            Bank_plus b = new Bank_plus();
            MoneyPrinter_plus mp = new MoneyPrinter_plus();
            Wallet some = new Wallet(b, mp);
            some.addMoney("USD", 100);
            some.addMoney("EUR", 100);
            int total = b.convert(100, "USD", "RUB");
            Assert.AreEqual(total, 6000);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PavajPtPiata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(1, calculatorPavaj(1, 1, 1));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(4, calculatorPavaj(6, 6, 4));
        }
        int calculatorPavaj(int lungime, int latime, int laturaPavaj)
        {
            int nrPavajLungime = lungime / laturaPavaj;
            if (lungime % laturaPavaj != 0)
            {
                nrPavajLungime++;
            }
            int nrPavajLatime = latime / laturaPavaj;
            if (latime % laturaPavaj != 0)
            {
                nrPavajLatime++;
            }
            return (nrPavajLungime * nrPavajLatime);
        }

    }
}
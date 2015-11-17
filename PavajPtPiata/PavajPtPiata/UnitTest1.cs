using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PavajPtPiata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          //  calculatorPavaj(1,1,1) == 1;

        }
    }
}
 int calculatorPavaj(int lungime, int latime, int laturaPavaj)
    {
    int nrPavajLungime = lungime / laturaPavaj;

    int nrPavajLatime = latime / laturaPavaj;

    return nrPavajLungime * nrPavajLatime ;
    }
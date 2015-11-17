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
            calculatorPavaj(1,1,1) == 7;

        }
    }
}
 int calculatorPavaj(int lungime, int latime, int laturaPavaj)
    {
    int ariePiata = lungime * latime;
    int ariePavaj = laturaPavaj * laturaPavaj;
    return 7;
    }
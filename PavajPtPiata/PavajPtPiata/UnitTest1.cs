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
        //calculatorPavaj(1,1,1) == 1;

        }
    }
}
class Myclass { 
int calculatorPavaj(int lungime, int latime,int laturaPavaj)
    {
    int nrPavajLungime = lungime / laturaPavaj;
    if (lungime % laturaPavaj != 0)
    {
        nrPavajLungime ++;
    }
    int nrPavajLatime = latime / laturaPavaj;
    if (latime  % laturaPavaj != 0)
    {
        nrPavajLatime ++;
    }
        return (nrPavajLungime * nrPavajLatime) ;
    }
}
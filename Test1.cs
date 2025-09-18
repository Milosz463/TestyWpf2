using ConsoleApp3;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestSzyfrujJesliPusteSlowo()
        {
            Assert.AreEqual("", Szyfr.szyfrujPrzestawieniowo(""));
        }
        [TestMethod]
        public void TestSzyfrujJesliSlowoODlugosciParzystej()
        {
            Assert.AreEqual("badc", Szyfr.szyfrujPrzestawieniowo("abcd"));
        }
        [TestMethod]
        public void TestSzyfrujJesliSlowoODlugosciNieParzystej()
        {
            Assert.AreEqual("badce", Szyfr.szyfrujPrzestawieniowo("abcde"));
        }

        [TestMethod]
        public void TestSzyfrujGaderypolutingJezeliPusteSlowo()
        {
            Assert.AreEqual("", Szyfr.szyfrujGaderypoluki("", "abc"));
        }
        [TestMethod]
        public void TestSzyfrujGaderypolutingJezeliNiePustyKlucz()
        {
            Assert.AreEqual("abc", Szyfr.szyfrujGaderypoluki("abc", ""));
        }
        [TestMethod]
        public void TestSzyfrujGwaderypolukiJezeliNiePustyKlucz2znakiNiePusteSlowo()
        {
            Assert.AreEqual("bacdefgba", Szyfr.szyfrujGaderypoluki("abcdefgab", "ab"));
        }
        [TestMethod]
        public void TestSzyfrujGwaderypolukiJezeliNiePustyKluczDluzszyznakiNiePusteSlowo()
        {
            Assert.AreEqual("badcfegbah", Szyfr.szyfrujGaderypoluki("abcdefgabh", "abcdef"));
        }
        [TestMethod]
        public void ZwrocSumeCyfr()
        {
            Assert.AreEqual(12, Obliczenia.sumaCyfr(6));
        }
        [TestMethod]
        public void ZwrocPotege()
        {
            Assert.AreEqual(9, Obliczenia.potega(3,2));
        }
    }
}

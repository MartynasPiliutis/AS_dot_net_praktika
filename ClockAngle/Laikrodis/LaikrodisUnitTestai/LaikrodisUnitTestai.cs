using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LaikrodisUnitTestai
{
    [TestClass]
    public class LaikrodisUnitTestai
    {
        [TestMethod]
        public void KampasTarpRodykliuTuriButi_0Laipsniu_KaiLaikrodisRodo_0Valanda()
        {
            int valandos = 0;
            int minutes = 0;
            double kampasTest = Laikrodis.LaikrodisKampas.PaskaiciuojaKampaTarpRodykliuIrIsvedaIKonsole(valandos, minutes);
            Assert.AreEqual(kampasTest, 0);
        }

        [TestMethod]
        public void KampasTarpRodykliuTuriButi_90Laipsniu_KaiLaikrodisRodo_3Valanda()
        {
            int valandos = 3;
            int minutes = 0;
            double kampasTest = Laikrodis.LaikrodisKampas.PaskaiciuojaKampaTarpRodykliuIrIsvedaIKonsole(valandos, minutes);
            Assert.AreEqual(kampasTest, 90);
        }

        [TestMethod]
        public void KampasTarpRodykliuTuriButi_180Laipsniu_KaiLaikrodisRodo_6Valanda()
        {
            int valandos = 6;
            int minutes = 0;
            double kampasTest = Laikrodis.LaikrodisKampas.PaskaiciuojaKampaTarpRodykliuIrIsvedaIKonsole(valandos, minutes);
            Assert.AreEqual(kampasTest, 180);
        }
        [TestMethod]
        public void KampasTarpRodykliuTuriButi_90Laipsniu_KaiLaikrodisRodo_9Valanda()
        {
            int valandos = 9;
            int minutes = 0;
            double kampasTest = Laikrodis.LaikrodisKampas.PaskaiciuojaKampaTarpRodykliuIrIsvedaIKonsole(valandos, minutes);
            Assert.AreEqual(kampasTest, 90);
        }

        [TestMethod]
        public void KampasTarpRodykliuTuriButi_0Laipsniu_KaiLaikrodisRodo_12Valanda()
        {
            int valandos = 12;
            int minutes = 0;
            double kampasTest = Laikrodis.LaikrodisKampas.PaskaiciuojaKampaTarpRodykliuIrIsvedaIKonsole(valandos, minutes);
            Assert.AreEqual(kampasTest, 0);
        }

        [TestMethod]
        public void KampasTarpRodykliuTuriButi_90Laipsniu_KaiLaikrodisRodo_15Valanda()
        {
            int valandos = 15;
            int minutes = 0;
            double kampasTest = Laikrodis.LaikrodisKampas.PaskaiciuojaKampaTarpRodykliuIrIsvedaIKonsole(valandos, minutes);
            Assert.AreEqual(kampasTest, 90);
        }

        [TestMethod]
        public void KampasTarpRodykliuTuriButi_180Laipsniu_KaiLaikrodisRodo_18Valanda()
        {
            int valandos = 18;
            int minutes = 0;
            double kampasTest = Laikrodis.LaikrodisKampas.PaskaiciuojaKampaTarpRodykliuIrIsvedaIKonsole(valandos, minutes);
            Assert.AreEqual(kampasTest, 180);
        }
        [TestMethod]
        public void KampasTarpRodykliuTuriButi_90Laipsniu_KaiLaikrodisRodo_21Valanda()
        {
            int valandos = 21;
            int minutes = 0;
            double kampasTest = Laikrodis.LaikrodisKampas.PaskaiciuojaKampaTarpRodykliuIrIsvedaIKonsole(valandos, minutes);
            Assert.AreEqual(kampasTest, 90);
        }

        [TestMethod]
        public void KampasTarpRodykliuTuriButi_90Laipsniu_30Minuciu_KaiLaikrodisRodo_1111Valanda()
        {
            int valandos = 11;
            int minutes = 11;
            double kampasTest = Laikrodis.LaikrodisKampas.PaskaiciuojaKampaTarpRodykliuIrIsvedaIKonsole(valandos, minutes);
            Assert.AreEqual(kampasTest, 90.5);
        }

        [TestMethod]
        public void KampasTarpRodykliuTuriButi_179Laipsniu_KaiLaikrodisRodo_2222Valanda()
        {
            int valandos = 22;
            int minutes = 22;
            double kampasTest = Laikrodis.LaikrodisKampas.PaskaiciuojaKampaTarpRodykliuIrIsvedaIKonsole(valandos, minutes);
            Assert.AreEqual(kampasTest, 179);
        }
    }
}
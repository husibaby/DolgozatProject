using DolgozatProject;
using NUnit.Framework;

namespace TestDolgozatProject
{
    public class Tests
    {
        Dolgozat dolgozat;
        [SetUp]
        public void Setup()
        {
            dolgozat = new Dolgozat();
        }

        [Test]
        public void PontFelvesz_MegfeleloJegyTest()
        {
            dolgozat.PontFelvesz(50);
            Assert.That(dolgozat.pontok.Contains(50), Is.EqualTo(true));
        }
        [Test]
        public void PontFelvesz_KisebbJegyTest()
        {

            Assert.Throws<ArgumentException>(() => dolgozat.PontFelvesz(-50));

        }
        [Test]
        public void PontFelvesz_NagyobbJegyTest()
        {
            Assert.Throws<ArgumentException>(() => dolgozat.PontFelvesz(101));
        }

        [Test]
        public void MindenkiMegirta_MindenkiMegirtaTest()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(80);
            dolgozat.PontFelvesz(60);
            Assert.That(dolgozat.MindenkiMegirta, Is.EqualTo(true));
        }

        [Test]
        public void MindenkiMegirta_NemIrtakMegMindenkiTest()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(80);
            dolgozat.PontFelvesz(-1);
            Assert.That(dolgozat.MindenkiMegirta, Is.EqualTo(false));
        }

        [Test]
        public void Bukas_BukasTest()
        {
            dolgozat.PontFelvesz(40);
            dolgozat.PontFelvesz(80);
            dolgozat.PontFelvesz(1);
            Assert.That(dolgozat.Bukas, Is.EqualTo(2));
        }

        [Test]
        public void Bukas_NincsBukasTest()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(80);
            dolgozat.PontFelvesz(60);
            Assert.That(dolgozat.Bukas, Is.EqualTo(0));
        }

        [Test]
        public void Elegseges_ElegsegesTest()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(60);
            dolgozat.PontFelvesz(90);
            Assert.That(dolgozat.Elegseges, Is.EqualTo(2));
        }
        [Test]
        public void Elegseges_NincsElegsegesTest()
        {
            dolgozat.PontFelvesz(49);
            dolgozat.PontFelvesz(80);
            dolgozat.PontFelvesz(61);
            Assert.That(dolgozat.Elegseges, Is.EqualTo(0));
        }
        [Test]
        public void Kozepes_KozepesTest()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(61);
            dolgozat.PontFelvesz(71);
            Assert.That(dolgozat.Kozepes, Is.EqualTo(1));
        }
        [Test]
        public void Kozepes_NincsKozepesTest()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(80);
            dolgozat.PontFelvesz(60);
            Assert.That(dolgozat.Kozepes, Is.EqualTo(0));
        }
        [Test]
        public void Jo_JoTest()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(60);
            dolgozat.PontFelvesz(71);
            Assert.That(dolgozat.Jo, Is.EqualTo(1));
        }
        [Test]
        public void Jo_NincsJoTest()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(81);
            dolgozat.PontFelvesz(60);
            Assert.That(dolgozat.Jo, Is.EqualTo(0));
        }
        [Test]
        public void Jeles_JelesTest()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(60);
            dolgozat.PontFelvesz(81);
            Assert.That(dolgozat.Jeles, Is.EqualTo(1));
        }
        [Test]
        public void Jeles_NincsJelesTest()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(80);
            dolgozat.PontFelvesz(60);
            Assert.That(dolgozat.Jeles, Is.EqualTo(0));
        }

        [Test]
        public void Gyanus_GyanusTest()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(90);
            dolgozat.PontFelvesz(81);
            Assert.That(dolgozat.Gyanus(1), Is.EqualTo(true));
        }
        [Test]
        public void Gyanus_NincsGyanusTest()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(85);
            dolgozat.PontFelvesz(60);
            Assert.That(dolgozat.Gyanus(2), Is.EqualTo(false));
        }
        [Test]
        public void Gyanus_RosszErtekTest()
        {
            Assert.Throws<ArgumentException>(() => dolgozat.Gyanus(-1));
        }
        [Test]
        public void Ervenytelen_ErvenytelenTest()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(-1);
            Assert.That(dolgozat.Ervenytelen, Is.EqualTo(true));
        }
        [Test]
        public void Ervenytelen_NincsErvenytelenTest()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(80);
            dolgozat.PontFelvesz(60);
            dolgozat.PontFelvesz(-1);
            Assert.That(dolgozat.Ervenytelen, Is.EqualTo(false));
        }
        [Test]
        public void Ervenytelen_ErvenytelenTest2()
        {
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(80);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(-1);
            Assert.That(dolgozat.Ervenytelen, Is.EqualTo(true));
        }
    }
}

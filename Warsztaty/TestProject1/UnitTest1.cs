using ConsoleApp2;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(70, 1.90)]
        [TestCase(60, 1.80)]
        [TestCase(90, 1.50)]
        [TestCase(110, 2.10)]
        public void Metoda_ktora_bada_czy_inkrmentacja_dziala(double waga, double wysokosc)
        {
            var bmi = waga / (wysokosc * wysokosc);

            var person = new Person(waga, wysokosc);
            var personBMI = person.GetBMI();

            Assert.AreEqual(true, true);
        }


    }
}
using StructuralPatterns;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class StructuralPatternsTests
    {
        [TestMethod]
        public void TestAdapter()
        {
            var adapter = new CustomerAdapter(new ExternalCustomerStore());
            var client = new CustomerManagement(adapter);

            var adaptedCustomers = client.DisplayCustomers();

            Assert.IsTrue(adaptedCustomers.Count() == 4);
            Assert.IsTrue(adaptedCustomers.First().Contains("adapted"));
        }

        [TestMethod]
        public void TestDecorator()
        {
            var blastoise = new Blastoise();

            Assert.IsTrue(blastoise.Name == "Blastoise");
            Assert.IsTrue(blastoise.HealthPoints == 180);
            Assert.IsTrue(blastoise.PrimaryAttack == "Hydro Pump");

            //DECORATOR!
            var megaBlastoise = new MegaBlastoise(blastoise);

            Assert.IsTrue(megaBlastoise.Name == "Mega Blastoise");
            Assert.IsTrue(megaBlastoise.HealthPoints == 220);
            Assert.IsTrue(megaBlastoise.PrimaryAttack == "Hydro Bombard");
        }

        [TestMethod]
        public void TestFacade()
        {
            var facade = new InfinityGauntletFacade();

            facade.AssembleInfinityGauntlet();
        }
    }
}

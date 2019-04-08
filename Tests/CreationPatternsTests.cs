using CreationPatterns;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTests
{
    [TestClass]
    public class CreationPatternsTests
    {
        [TestMethod]
        public void TestSingleton()
        {
            var singleton = Singleton.Instance;

            Assert.AreEqual(1, singleton.ID);
            Assert.AreEqual("There should only be one of me!", singleton.Description);
        }

        [TestMethod]
        public void TestFactory()
        {
            BookFactory factory = new ConcreteBookFactory();

            var smallBook = factory.Create(BookType.Small);

            Assert.AreEqual(10, smallBook.Pages);

            var largeBook = factory.Create(BookType.Large);

            Assert.AreEqual(100, largeBook.Pages);
        }

        [TestMethod]
        public void TestAbstractFactory()
        {
            //Nissan Factory client
            var nissanFactoryClient = new VehicleFactoryClient(new NissanFactory());

            var nissanHatch = nissanFactoryClient.Create(CarType.Hatch);

            Assert.AreEqual("Nissan Tiida", nissanHatch.Name);

            var nissan4WD = nissanFactoryClient.Create(SuvType.FourWD);

            Assert.AreEqual("Nissan Terrano", nissan4WD.Name);

            //Toyota Factory client
            var toyotaFactoryClient = new VehicleFactoryClient(new ToyotaFactory());

            var toyotaSedan = toyotaFactoryClient.Create(CarType.Sedan);

            Assert.AreEqual("Toyota Camry", toyotaSedan.Name);

            var toyotaCrossover = toyotaFactoryClient.Create(SuvType.CrossOver);

            Assert.AreEqual("Toyota RAV4", toyotaCrossover.Name);
        }

        [TestMethod]
        public void TestBuilder()
        {
            //Blastoise!
            var blastoiseCreator = new PokemonCreator(new BlastoiseBuilder());

            blastoiseCreator.CreatePokemon();

            var blastoise = blastoiseCreator.GetPokemon();

            Assert.AreEqual("Blastoise", blastoise.Name);
            Assert.AreEqual(PokemonRegion.Kanto, blastoise.Origin);
            Assert.AreEqual(PokemonType.Water, blastoise.Type);

            //Incineroar!
            var incineroarCreator = new PokemonCreator(new IncineroarBuilder());

            incineroarCreator.CreatePokemon();

            var incineroar = incineroarCreator.GetPokemon();

            Assert.AreEqual("Incineroar", incineroar.Name);
            Assert.AreEqual(PokemonType.Water, incineroar.Weakness);
            Assert.AreEqual(180, incineroar.HealthPoints);
        }
    }
}

using Autofac;
using NUnit.Framework;
using singleton.Singleton;

namespace singleton.tests
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void IsSingleTonTest()
        {
            var db = SingletonDatabase.Instance;
            var db2 = SingletonDatabase.Instance;
            Assert.That(db, Is.SameAs(db2));
            Assert.That(SingletonDatabase.Count, Is.EqualTo(1));
        }
    
        [Test]
        public void SingleTotalPopulationTest()
        {
            var rf = new SingletonRecordFinder();
            var names = new[] { "Seoul", "Mexico City" };
            var tp = rf.GetTotalPopulation(names);
            Assert.That(tp, Is.EqualTo(17500000 + 17400000));
        }
    
        [Test]
        public void ConfigurablePopulationTest()
        {
            var rf = new ConfigurableRecordFinder(new DummyDatabase());
            Assert.That(
                rf.GetTotalPopulation(new[] { "alpha", "gamma" }),
                Is.EqualTo(4));
        }
    
        [Test]
        public void DIPopulationTest()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<DummyDatabase>() //cb.RegisterType<OrdinaryDatabase>()
                .As<IDatabase>()
                .SingleInstance();
            cb.RegisterType<ConfigurableRecordFinder>();
            using var c = cb.Build();
            var rf = c.Resolve<ConfigurableRecordFinder>();
            Assert.That(
                rf.GetTotalPopulation(new[] { "alpha", "gamma" }),
                Is.EqualTo(4));
        }
    }
}
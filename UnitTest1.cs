using NUnit.Framework;

namespace rp_nunit_crosstest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ReportPortal.Shared.Log.Info("qwe");
            Assert.Pass();
        }
    }
}
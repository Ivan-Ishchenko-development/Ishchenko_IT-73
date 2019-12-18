using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2_.Target;

namespace Lab2_UnitTest
{
    [TestClass]
    public class FactoryMethodTargetsUnitTests
    {
        public Targets CreateTNormalTarget()
        {
            return new TNormalCreator().Create();
        }
        public Targets CreateTPoisonTarget()
        {
            return new TPoisonCreator().Create();
        }
        public Targets CreateTDecodingTarget()
        {
            return new TDecodingCreator().Create();
        }



        [TestMethod]
        public void TNormalStats()
        {
            var target = CreateTNormalTarget();

            Assert.AreEqual(target.Name, "N");

        }

        [TestMethod]
        public void TDecodingStats()
        {
            var target = CreateTDecodingTarget();

            Assert.AreEqual(target.Name, "D");

        }

        [TestMethod]
        public void TPoisonStats()
        {
            var target = CreateTPoisonTarget();

            Assert.AreEqual(target.Name, "P");

        }
    }
}

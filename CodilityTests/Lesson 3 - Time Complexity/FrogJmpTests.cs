using Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityTests
{
    [TestClass]
    public class FrogJmpTests
    {
        [TestMethod]
        public void FrogJmp_SimpleExample_Success()
        {
            Assert.AreEqual(3, FrogJmp.Solution(10, 85, 30));
        }

        [TestMethod]
        public void FrogJmp_ExactJump_Success()
        {
            Assert.AreEqual(4, FrogJmp.Solution(10, 90, 20));
        }

        [TestMethod]
        public void FrogJmp_MultipleJumps_Success()
        {
            Assert.AreEqual(50000000, FrogJmp.Solution(10, 1000000000, 20));
        }

        [TestMethod]
        public void FrogJmp_NoJump_Success()
        {
            Assert.AreEqual(0, FrogJmp.Solution(10, 10, 20));
        }


        [TestMethod]
        public void FrogJmp_BigJump_Success()
        {
            Assert.AreEqual(1, FrogJmp.Solution(10, 11, 1000000000));
        }
    }
}

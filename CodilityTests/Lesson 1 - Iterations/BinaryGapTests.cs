using Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityTests
{
    [TestClass]
    public class BinaryGapTests
    {
        [TestMethod]
        public void BinaryGap_OneGap_Success()
        {
            Assert.AreEqual(2,BinaryGap.Solution(9));
        }

        [TestMethod]
        public void BinaryGap_TwoGaps_Success()
        {
            Assert.AreEqual(4, BinaryGap.Solution(529));
        }

        [TestMethod]
        public void BinaryGap_OneGapStartWithZero_Success()
        {
            Assert.AreEqual(1, BinaryGap.Solution(20));
        }

        [TestMethod]
        public void BinaryGap_NoGap_Success()
        {
            Assert.AreEqual(0, BinaryGap.Solution(15));
        }

        [TestMethod]
        public void BinaryGap_PowOfTwo_Success()
        {
            Assert.AreEqual(0, BinaryGap.Solution(16));
        }

        [TestMethod]
        public void BinaryGap_LargeNumber_Success()
        {
            Assert.AreEqual(28, BinaryGap.Solution(1610612737));
        }
    }
}

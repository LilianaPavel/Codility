using Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityTests
{
    [TestClass]
    public class TapeEquilibriumTests
    {
        [TestMethod]
        public void TapeEquilibrium_EmptyArray_Success()
        {
            Assert.AreEqual(0, TapeEquilibrium.Solution(new int[] { }));
        }

        [TestMethod]
        public void TapeEquilibrium_OneElement_Success()
        {
            Assert.AreEqual(1, TapeEquilibrium.Solution(new int[] { 1}));
        }

        [TestMethod]
        public void TapeEquilibrium_TwoElements_Success()
        {
            Assert.AreEqual(2, TapeEquilibrium.Solution(new int[] { 1, 3 }));
        }

        [TestMethod]
        public void TapeEquilibrium_SmallArray_Success()
        {
            Assert.AreEqual(1, TapeEquilibrium.Solution(new int[] { 3, 1, 2, 4, 3 }));
        }

        [TestMethod]
        public void TapeEquilibrium_NegativeValues_Success()
        {
            Assert.AreEqual(4, TapeEquilibrium.Solution(new int[] { -3, -1, -7, -4, -3 }));
        }
    }
}

using Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityTests
{
    [TestClass]
    public class MissingIntegerTests
    {
        [TestMethod]
        public void MissingInteger_EmptyArray_Success()
        {
            Assert.AreEqual(1, MissingInteger.Solution(new int[] { }));
        }

        [TestMethod]
        public void MissingInteger_LastElement_Success()
        {
            Assert.AreEqual(3, MissingInteger.Solution(new int[] { 1, 2 }));
        }

        [TestMethod]
        public void MissingInteger_IntermediateElement_Success()
        {
            Assert.AreEqual(2, MissingInteger.Solution(new int[] { 1, 3 }));
        }

        [TestMethod]
        public void MissingInteger_FirstElement_Success()
        {
            Assert.AreEqual(1, MissingInteger.Solution(new int[] { 2, 3 }));
        }

        [TestMethod]
        public void MissingInteger_NegativeValues_Success()
        {
            Assert.AreEqual(1, MissingInteger.Solution(new int[] { -1, -2 }));
        }

        [TestMethod]
        public void MissingInteger_MixtValues_Success()
        {
            Assert.AreEqual(3, MissingInteger.Solution(new int[] { -1, -2, 1, 2 }));
        }

        [TestMethod]
        public void MissingInteger_ElementZero_Success()
        {
            Assert.AreEqual(1, MissingInteger.Solution(new int[] { 0 }));
        }
    }
}

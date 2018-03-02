using Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityTests
{
    [TestClass]
    public class CyclicRotationTests
    {
        [TestMethod]
        public void CyclicRotation_NoRotation_Success()
        {
            int[] result = CyclicRotation.Solution(new int[] { 1, 2, 3, 4 }, 0);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, result);
        }

        [TestMethod]
        public void CyclicRotation_KLessN_Success()
        {
            int[] result = CyclicRotation.Solution(new int[] { 1, 2, 3, 4 }, 2);
            CollectionAssert.AreEqual(new int[] { 3, 4, 1, 2 }, result);
        }

        [TestMethod]
        public void CyclicRotation_KEqualsN_Success()
        {
            int[] result = CyclicRotation.Solution(new int[] { 1, 2, 3, 4 }, 4);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, result);
        }

        [TestMethod]
        public void CyclicRotation_KGreaterN_Success()
        {
            int[] result = CyclicRotation.Solution(new int[] { 1, 2, 3, 4 }, 6);
            CollectionAssert.AreEqual(new int[] { 3, 4, 1, 2 }, result);
        }
    }
}

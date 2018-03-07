using Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityTests
{
    [TestClass]
    public class PermCheckTests
    {
        [TestMethod]
        public void PermCheck_OneElement_WithPerm_Success()
        {
            Assert.AreEqual(1, PermCheck.Solution(new int[] { 1 }));
        }

        [TestMethod]
        public void PermCheck_OneElement_NoPerm_Success()
        {
            Assert.AreEqual(0, PermCheck.Solution(new int[] { 2 }));
        }

        [TestMethod]
        public void PermCheck_SmallArray_WithPerm_Success()
        {
            Assert.AreEqual(1, PermCheck.Solution(new int[] { 1, 2, 4, 3 }));
        }

        [TestMethod]
        public void PermCheck_SmallArray_LessN_NoPerm_Success()
        {
            Assert.AreEqual(0, PermCheck.Solution(new int[] { 1, 2, 1, 3 }));
        }

        [TestMethod]
        public void PermCheck_SmallArray_GreaterN_NoPerm_Success()
        {
            Assert.AreEqual(0, PermCheck.Solution(new int[] { 1, 2, 6, 3 }));
        }

        [TestMethod]
        public void PermCheck_SmallArray_SumCorrect_NoPerm_Success()
        {
            Assert.AreEqual(0, PermCheck.Solution(new int[] { 1, 4, 1 }));
        }
    }
}

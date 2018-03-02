using Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityTests
{
    [TestClass]
    public class PermMissingElemTests
    {
        [TestMethod]
        public void PermMissingElem_EmptyArray_Success()
        {
            Assert.AreEqual(1, PermMissingElem.Solution(new int[] { }));
        }

        [TestMethod]
        public void PermMissingElem_OneElem_Success()
        {
            Assert.AreEqual(1, PermMissingElem.Solution(new int[] { 2}));
        }

        [TestMethod]
        public void PermMissingElem_SmallArray_Success()
        {
            Assert.AreEqual(3, PermMissingElem.Solution(new int[] { 2, 1, 4 }));
        }

        [TestMethod]
        public void PermMissingElem_FirstElem_Success()
        {
            Assert.AreEqual(1, PermMissingElem.Solution(new int[] { 2, 4, 3 }));
        }

        [TestMethod]
        public void PermMissingElem_LastElem_Success()
        {
            Assert.AreEqual(4, PermMissingElem.Solution(new int[] { 2, 1, 3 }));
        }
    }
}

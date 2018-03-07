using Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityTests
{
    [TestClass]
    public class FrogRiverOneTests
    {
        [TestMethod]
        public void FrogRiverOne_OneLeaf_Success()
        {
            Assert.AreEqual(0, FrogRiverOne.Solution(1, new int[] { 1 }));
        }

        [TestMethod]
        public void FrogRiverOne_SomeLeaves_CanJump_Success()
        {
            Assert.AreEqual(3, FrogRiverOne.Solution(4, new int[] { 1, 3, 4, 2 }));
        }

        [TestMethod]
        public void FrogRiverOne_SomeLeaves_CannotJump_Success()
        {
            Assert.AreEqual(-1, FrogRiverOne.Solution(4, new int[] { 1, 3, 4, 3 }));
        }

        [TestMethod]
        public void FrogRiverOne_RepeatPosition_CanJump_Success()
        {
            Assert.AreEqual(5, FrogRiverOne.Solution(4, new int[] { 1, 3, 3, 1, 4, 2, 2 }));
        }

        [TestMethod]
        public void FrogRiverOne_RepeatPosition_CannotJump_Success()
        {
            Assert.AreEqual(-1, FrogRiverOne.Solution(6, new int[] { 1, 3, 4, 3, 1, 4 }));
        }
    }
}

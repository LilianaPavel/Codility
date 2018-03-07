using Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityTests
{
    [TestClass]
    public class MaxCountersTests
    {
        [TestMethod]
        public void MaxCounters_SmallArray_LastMaxCounter_Correct()
        {
            CollectionAssert.AreEqual(new int[] { 2, 2, 2}, MaxCounters.Solution(3, new int[] { 1, 2, 2, 4 }));
        }

        [TestMethod]
        public void MaxCounters_SmallArray_LastIncrease_Correct()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 1 }, MaxCounters.Solution(3, new int[] { 1, 2, 4, 2 }));
        }

        [TestMethod]
        public void MaxCounters_SmallArray_MultipleMaxCounter_Correct()
        {
            CollectionAssert.AreEqual(new int[] { 2, 3, 2 }, MaxCounters.Solution(3, new int[] { 1, 2, 4, 2, 4, 2}));
        }

        [TestMethod]
        public void MaxCounters_SmallArray_JustMaxCounter_Correct()
        {
            CollectionAssert.AreEqual(new int[] { 0, 0, 0 }, MaxCounters.Solution(3, new int[] { 4, 4, 4 }));
        }

        [TestMethod]
        public void MaxCounters_SmallArray_JustIncrease_Correct()
        {
            CollectionAssert.AreEqual(new int[] { 3, 0, 0 }, MaxCounters.Solution(3, new int[] { 1, 1, 1 }));
        }
    }
}

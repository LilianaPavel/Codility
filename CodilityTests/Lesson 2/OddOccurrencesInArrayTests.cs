using Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityTests
{
    [TestClass]
    public class OddOccurrencesInArrayTests
    {
        [TestMethod]
        public void OddOccurrencesInArray_OneElement_Success()
        {
            int result = OddOccurrencesInArray.Solution(new int[] { 1 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void OddOccurrencesInArray_OneOccurance_Success()
        {
            int result = OddOccurrencesInArray.Solution(new int[] { 1, 2, 1 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void OddOccurrencesInArray_ThreeOccurances_Success()
        {
            int result = OddOccurrencesInArray.Solution(new int[] { 1, 2, 1 , 2, 1, 2, 1});
            Assert.AreEqual(2, result);
        }
    }
}

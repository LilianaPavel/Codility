namespace Codility
{
    public class OddOccurrencesInArray
    {
        /// <summary>
        /// Find the element that has odd occurances in the array
        /// 
        /// Assume that:
        /// - N is an odd integer within the range[1..1, 000, 000];
        /// - each element of array A is an integer within the range[1..1, 000, 000, 000];
        /// - all but one of the values in A occur an even number of times.
        ///
        /// Complexity:
        /// - expected worst-case time complexity is O(N);
        /// - expected worst-case space complexity is O(1)
        /// </summary>
        /// <param name="array">an array with odd number of elements</param>
        /// <returns>elem with odd occurrences</returns>
        public static int Solution(int[] array)
        {
            int app = 0;

            foreach(var elem in array)
            {
                app = app ^ elem;
            }
            return app;
        }
    }
}

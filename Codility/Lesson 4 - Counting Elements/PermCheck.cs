
namespace Codility
{
    public class PermCheck
    {
        /// <summary>
        /// A non-empty zero-indexed array A consisting of N integers is given.
        /// A permutation is a sequence containing each element from 1 to N once, and only once.
        /// 
        /// Assume that:
        /// - N is an integer within the range[1..100, 000];
        /// - each element of array A is an integer within the range[1..1, 000, 000, 000].
        /// Complexity:
        /// - expected worst-case time complexity is O(N);
        /// - expected worst-case space complexity is O(N), beyond input storage(not counting the storage required for input arguments).
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Solution(int[] array)
        {
            int[] sum = new int[array.Length];
            foreach(var elem in array)
            {
                if (elem > array.Length)
                {
                    return 0;
                }
                if (sum[elem - 1] == 1)
                {
                    return 0;
                }

                sum[elem - 1]++;
            }
            return 1;
        }
    }
}

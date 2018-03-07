
namespace Codility
{
    public class MaxCounters
    {
        /// <summary>
        /// You are given N counters, initially set to 0, and you have two possible operations on them:
        /// - increase(X) − counter X is increased by 1,
        /// - max counter − all counters are set to the maximum value of any counter.
        /// 
        /// A non-empty zero-indexed array A of M integers is given. This array represents consecutive operations:
        /// - if A[K] = X, such that 1 ≤ X ≤ N, then operation K is increase(X),
        /// - if A[K] = N + 1 then operation K is max counter.
        /// 
        /// Given an integer N and a non-empty zero-indexed array A consisting of M integers, returns a sequence of integers representing the values of the counters.
        /// 
        /// Assume that:
        /// - N and M are integers within the range[1..100, 000];
        /// - each element of array A is an integer within the range[1..N + 1].
        /// 
        /// Complexity:
        /// - expected worst-case time complexity is O(N+M);
        /// - expected worst-case space complexity is O(N), beyond input storage(not counting the storage required for input arguments).
        /// </summary>
        /// <returns></returns>
        public static int[] Solution(int n, int[] array)
        {
            int[] result = new int[n];
            int curMax = 0, useMax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                var elem = array[i] - 1;
                if (elem < n)
                {
                    result[elem] = FindMax(result[elem], useMax) + 1;
                    if (result[elem] > curMax)
                    {
                        curMax = result[elem];
                    }
                }
                else
                {
                    useMax = curMax;
                }
            
            }

            for(int i=0; i < n; i++)
            {
                result[i] = FindMax(result[i], useMax);
            }
            return result;
        }

        private static int FindMax(int n1, int n2)
        {
            return (n1 > n2) ? n1 : n2;
        }
    }
}

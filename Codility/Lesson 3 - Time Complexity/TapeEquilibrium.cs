using System;

namespace Codility
{
    public class TapeEquilibrium
    {
        /// <summary>
        /// A non-empty zero-indexed array A consisting of N integers is given. Array A represents numbers on a tape.
        ///
        /// Any integer P, such that N > P > 0, splits this tape into two non-empty parts: A[0], A[1], ..., A[P − 1] and A[P], A[P + 1], ..., A[N − 1].
        /// The difference between the two parts is the value of: |(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|
        /// 
        /// Assume that:
        /// - N is an integer within the range[2..100, 000];
        /// - each element of array A is an integer within the range[−1, 000..1, 000].
        /// 
        /// Write a function that, given a non-empty zero-indexed array A of N integers, returns the minimal difference that can be achieved.
        /// 
        /// Complexity:
        /// - expected worst-case time complexity is O(N);
        /// - expected worst-case space complexity is O(N), beyond input storage(not counting the storage required for input arguments).
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Solution(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }

            int right = 0;
            for (int i = 1; i < array.Length ; i++)
            {
                right += array[i];
            }

            int left = array[0];
            int min = Math.Abs(left - right);
            for (int i=1; i < array.Length -1; i++)
            {
                left += array[i];
                right -= array[i];
                if (Math.Abs(left-right) < min)
                {
                    min = Math.Abs(left - right);
                }
            }
            return min;
        }
    }
}

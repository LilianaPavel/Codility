using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class MissingInteger
    {
        /// <summary>
        /// Given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
        /// 
        /// Assume that:
        /// - N is an integer within the range[1..100, 000];
        /// - each element of array A is an integer within the range[−1, 000, 000..1, 000, 000].
        /// 
        /// Complexity:
        /// - expected worst-case time complexity is O(N);
        /// - expected worst-case space complexity is O(N), beyond input storage(not counting the storage required for input arguments).
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Solution(int[] array)
        {
            int[] appearances = new int[array.Length];

            foreach(var elem in array)
            { 
                if (elem < 1 || elem > array.Length )
                {
                    continue;
                }

                appearances[elem - 1]++;
            }

            for(int i=0; i < appearances.Length; i++)
            {
                if (appearances[i] == 0)
                {
                    return i+1;
                }
            }
            return array.Length + 1;
        }
    }
}

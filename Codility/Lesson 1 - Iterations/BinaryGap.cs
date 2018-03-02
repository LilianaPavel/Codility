
namespace Codility
{
    public class BinaryGap
    {
        /// <summary>
        /// A binary gap within a positive integer N is any maximal sequence of consecutive zeros 
        /// that is surrounded by ones at both ends in the binary representation of N.
        /// 
        /// e.g: 
        /// 9 (1001) => 2
        /// 20 (10100) => 1
        /// 
        /// Assume that:
        /// - N is an integer within the range[1..2, 147, 483, 647].
        ///
        /// Complexity:
        /// - expected worst-case time complexity is O(log(N));
        /// - expected worst-case space complexity is O(1).
        /// </summary>
        /// <param name="n">positive integer</param>
        /// <returns>binary gap length</returns>
        public static int Solution(int n)
        {
            int gap = 0, count = -1;
            while (n > 0)
            {
                if( (n & 1) != 0)
                {
                    count = 0;
                }
                else
                {
                    if (count != -1)
                    {
                        count++;
                    }
                }
                n = n >> 1;
                if (count > gap)
                {
                    gap = count;
                }
            }
            return gap;
        }
    }
}

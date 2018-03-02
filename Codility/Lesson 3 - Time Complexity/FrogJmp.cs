
namespace Codility
{
    public class FrogJmp
    {
        /// <summary>
        /// A small frog wants to get to the other side of the road. The frog is currently located at position X and wants to get to a position greater than or equal to Y. The small frog always jumps a fixed distance, D.
        /// 
        /// Count the minimal number of jumps that the small frog must perform to reach its target.
        /// 
        /// Assume that:
        /// 
        /// - X, Y and D are integers within the range[1..1, 000, 000, 000];
        /// - X ≤ Y.
        /// 
        /// Complexity:
        /// - expected worst-case time complexity is O(1);
        /// - expected worst-case space complexity is O(1).
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int Solution(int x, int y, int d)
        {
            int div = (y - x) / d;
            int mod = (y - x) % d;
            return div + (mod != 0 ? 1: 0);
        }
    }
}

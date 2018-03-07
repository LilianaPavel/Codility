
namespace Codility
{
    public class FrogRiverOne
    {
        /// <summary>
        /// A small frog wants to get to the other side of a river. The frog is initially located on one bank of the river (position 0) and wants to get to the opposite bank (position X+1). Leaves fall from a tree onto the surface of the river.
        /// 
        /// You are given a zero-indexed array A consisting of N integers representing the falling leaves. A[K] represents the position where one leaf falls at time K, measured in seconds.
        /// 
        /// The goal is to find the earliest time when the frog can jump to the other side of the river. The frog can cross only when leaves appear at every position across the river from 1 to X (that is, we want to find the earliest moment when all the positions from 1 to X are covered by leaves). You may assume that the speed of the current in the river is negligibly small, i.e. the leaves do not change their positions once they fall in the river.
        /// Given a non-empty zero-indexed array A consisting of N integers and integer X, returns the earliest time when the frog can jump to the other side of the river.
        /// If the frog is never able to jump to the other side of the river, the function should return −1.
        /// 
        /// Assume that:
        /// - N and X are integers within the range[1..100, 000];
        /// - each element of array A is an integer within the range[1..X].
        /// 
        /// Complexity:
        /// - expected worst-case time complexity is O(N);
        /// - expected worst-case space complexity is O(X), beyond input storage(not counting the storage required for input arguments).
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Solution(int x, int[] array)
        {
            int[] pos = new int[x];
            int max = -1;

            for (int i = 0; i < x; i++)
            {
                pos[i] = -1;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= x && pos[array[i]-1] == -1)
                {
                    pos[array[i] - 1] = i;
                    max = i;
                }
            }

            foreach(var elem in pos)
            {
                if (elem == -1)
                {
                    return -1;
                }
            }
            return max;
        }
    }
}

namespace Codility
{
    public class PermMissingElem
    {
        /// <summary>
        /// A zero-indexed array A consisting of N different integers is given. The array contains integers in the range [1..(N + 1)], which means that exactly one element is missing.
        /// 
        /// Your goal is to find that missing element.
        /// 
        /// Assume that:
        /// - N is an integer within the range[0..100, 000];
        /// - the elements of A are all distinct;
        /// - each element of array A is an integer within the range[1..(N + 1)].
        /// 
        /// Complexity:
        /// -expected worst-case time complexity is O(N);
        /// -expected worst-case space complexity is O(1), beyond input storage(not counting the storage required for input arguments).
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Solution(int[] array)
        {
            int n = array.Length;
            int sum = 0, arrSum = 0;
            for (int i=1; i <= n + 1; i++)
            {
                sum += i;
            }

            foreach(var elem in array)
            {
                arrSum += elem;
            }
            return sum - arrSum;
        }
    }
}

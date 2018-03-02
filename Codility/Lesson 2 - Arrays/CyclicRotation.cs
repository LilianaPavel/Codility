namespace Codility
{
    public class CyclicRotation
    {
        /// <summary>
        /// Rotate to the right an array with N elements by K times.
        /// 
        /// Assume that:
        /// - N and K are integers within the range[0..100];
        /// - each element of array A is an integer within the range[−1, 000..1, 000].
        /// </summary>
        /// <param name="array"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int[] Solution(int[] array, int K)
        {
            if (array.Length != 0)
            {
                int times = K % array.Length;
                int last;
                for (var i = 0; i < times; i++)
                {
                    last = array[array.Length - 1];
                    for (var j = array.Length - 2; j >= 0; j--)
                    {
                        array[j + 1] = array[j];
                    }
                    array[0] = last;
                }
            }
            return array;
        }
    }
}

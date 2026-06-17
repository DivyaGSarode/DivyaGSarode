using System;

namespace GCDFinder
{
    /// <summary>
    /// Provides methods for computing the Greatest Common Divisor (GCD).
    /// </summary>
    public static class GcdFinder
    {
        /// <summary>
        /// Finds the Greatest Common Divisor (GCD) of two numbers using the Euclidean algorithm.
        /// Negative inputs are normalized to their absolute values.
        /// </summary>
        /// <param name="a">The first integer.</param>
        /// <param name="b">The second integer.</param>
        /// <returns>The greatest common divisor of <paramref name="a"/> and <paramref name="b"/>.</returns>
        public static int FindGCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}

using System;

namespace FindBalanceElementTask
{
    /// <summary>
    /// Class for operations with arrays.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds an index of element in an integer array for which the sum of the elements
        /// on the left and the sum of the elements on the right are equal.
        /// </summary>
        /// <param name="array">Source array.</param>
        /// <returns>The index of the balance element, if it exists, and null otherwise.</returns>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when source array is empty.</exception>
        public static int? FindBalanceElement(int[]? array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("Array cannnot be empty");
            }

            int index = -1, comp1, comp2;
            long sum1, sum2;
            for (int i = 0; i < array.Length; i++)
            {
                sum1 = 0;
                sum2 = 0;
                comp1 = 0;
                comp2 = 0;
                for (int j = 0; j < i; j++)
                {
                    sum1 += array[j];
                    comp1 = 1;
                }

                for (int j = i + 1; j < array.Length; j++)
                {
                    sum2 += array[j];
                    comp2 = 1;
                }

                if (sum1 == sum2 && comp1 == 1 && comp2 == 1)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                return null;
            }

            return index;
        }
    }
}

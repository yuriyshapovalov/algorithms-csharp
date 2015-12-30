using System;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Comb sort algorithm
    ///  https://en.wikipedia.org/wiki/Comb_sort
    ///  
    ///  Method: Exchange
    ///  Stable: No
    ///  Worst case performance: O(n^2)
    ///  Best case performance: Ω(n)
    ///  Average case performance: O(n^2 / 2^p)
    ///  Worst space complexity: O(1)
    /// </summary>
    public class CombSort<T> : ISort<T> where T : IComparable<T>, new()
    {
        public T[] Sort(T[] array)
        {
            int gap = array.Length;
            bool swapped = true;

            while (gap > 1 || swapped)
            {
                if (gap > 1)
                    gap = (int) gap / 2;

                int i = 0;
                swapped = false;

                while (i + gap < array.Length)
                {
                    if (array[i].CompareTo(array[i + gap]) > 0)
                    {
                        T tmp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = tmp;
                        swapped = true;
                    }
                    i++;
                }
            }
            return array;
        }
    }
}

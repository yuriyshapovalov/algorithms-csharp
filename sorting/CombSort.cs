using System;

namespace AaDS.Sorting
{
    /// <summary>
    /// Comb sort algorithm
    ///  O(n^2)
    ///  Θ(n^2 / 2^p) where p is a number of increments
    /// </summary>
    public class CombSort<T> : ISort<T> where T : IComparable, new()
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

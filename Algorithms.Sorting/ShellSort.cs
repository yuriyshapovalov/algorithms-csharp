using System;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Shellsort algorithm
    ///  https://en.wikipedia.org/wiki/Shellsort
    ///  
    ///  Method: Selection
    ///  Stable: No
    ///  Worst case performance: O(n^2)
    ///  Best case performance: Ω(n log n)
    ///  Average case performance: depends on gap sequence
    ///  Space: O(1)
    /// </summary>
    public class ShellSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            int gap = (int)array.Length / 2;

            while (gap > 0)
            {
                // for all elements in array
                for (int i = 0; i < array.Length - gap; i++)
                {
                    // go from 'i' cursor in reverse order 
                    int j = i + gap;

                    // select element under cursor
                    T element = array[j];
                    
                    for (; j >= gap && (array[j-gap].CompareTo(element) > 0); j-= gap) // array[j-gap] > element
                    {
                        array[j] = array[j - gap];
                    }
                    array[j] = element;
                }

                if (gap == 1)
                    gap = 0;
                else
                    gap = (int) gap / 2;
            }
        }
    }
}

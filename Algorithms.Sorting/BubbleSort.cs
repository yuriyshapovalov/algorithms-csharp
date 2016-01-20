using System;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Bubble sort algorithm
    ///  https://en.wikipedia.org/wiki/Bubble_sort
    ///  
    ///  Method: Exchange
    ///  Stable: Yes
    ///  Worst case performance: O(n^2)
    ///  Best case performance: Ω(n)
    ///  Average case performance: O(n^2)
    ///  Worst space complexity: O(1)
    /// </summary>
    public class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            bool clear = false;
            while (!clear)
            {
                clear = true;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0) // array[i] > array[i + 1]
                    {
                        clear = false;

                        T temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }
    }
}

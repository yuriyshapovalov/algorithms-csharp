using System;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Insertion sort algorithm
    ///  https://en.wikipedia.org/wiki/Insertion_sort
    ///  
    ///  Method: Insertion
    ///  Stable: Yes
    ///  Worst case performance: O(n^2)
    ///  Best case performance: Ω(n)
    ///  Average case performance: O(n^2)
    ///  Worst space complexity: O(n)
    /// </summary>
    public class InsertionSort<T> : ISort<T> where T : IComparable<T>, new()
    {
        public T[] Sort(T[] array)
        {
            // for all elements in array
            for (int i = 0; i < array.Length; i++)
            {
                // select element under cursor
                T element = array[i];

                // go from 'i' cursor in reverse order 
                int j = i - 1;
                //TODO: Do not move array, until proper place is found. (not effective for already sorted array)
                for (; j >= 0 && (array[j].CompareTo(element) > 0); j--) // array[j] > element
                {
                    array[j + 1] = array[j];
                }
                array[j + 1] = element;
            }
            return array;
        }
    }
}

using System;

namespace AaDS.Sorting
{
    /// <summary>
    /// Insertion sort algorithm
    ///  Θ(n) ~ N^2
    /// </summary>
    public class InsertionSort<T> : ISort<T> where T : IComparable, new()
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

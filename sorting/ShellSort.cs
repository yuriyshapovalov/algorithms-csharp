using System;

namespace AaDS.Sorting
{
    /// <summary>
    /// Shell sort algorithm
    ///  Θ(n) ~ ____
    /// </summary>
    public class ShellSort<T> : ISort<T> where T : IComparable, new()
    {
        public T[] Sort(T[] array)
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
            return array;
        }
    }
}

using System;

namespace AaDS.Sorting
{
    /// <summary>
    /// Bubble sort algorithm
    ///  Θ(N^2)
    /// </summary>
    public class BubbleSort<T> : ISort<T> where T : IComparable, new()
    {
        public T[] Sort(T[] array)
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
            return array;
        }
    }
}

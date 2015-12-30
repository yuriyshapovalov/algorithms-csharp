using System;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Coctail sort algorithm
    ///  https://en.wikipedia.org/wiki/Cocktail_sort
    ///  
    ///  Method: Exchange
    ///  Stable: Yes
    ///  Worst case performance: O(n^2)
    ///  Best case performance: Ω(n)
    ///  Average case performance: O(n^2)
    ///  Worst space complexity: O(1)
    /// </summary>
    public class CoctailSort<T> : ISort<T> where T : IComparable<T>, new()
    {
        public T[] Sort(T[] array)
        {
            int arrLenght = array.Length;

            for (int i = 0; i < arrLenght / 2; i++)
            {
                bool swapped = false;

                for (int j = i; j < arrLenght - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                for (int j = arrLenght - i - 2; j > i; j--)
                {
                    if (array[j].CompareTo(array[j - 1]) < 0)
                    {
                        T temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
            return array;
        }
    }
}

using System;

namespace AaDS.Sorting
{
    /// <summary>
    /// Coctail sort algorithm
    ///  Θ(n) ~ n^2
    /// </summary>
    public class CoctailSort<T> : ISort<T> where T : IComparable, new()
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

using System;

namespace Algorithms.Sorting
{
    /// /// <summary>
    /// Merge sort algorithm
    ///  https://en.wikipedia.org/wiki/Merge_sort
    ///  
    ///  Method: Merging
    ///  Stable: Yes
    ///  Worst case performance: O(n log n)
    ///  Best case performance: Ω(n log n)
    ///  Average case performance: O(n log n)
    ///  Space: O(n)
    /// </summary>
    public class MergeSort<T> : ISort<T> where T : IComparable<T>, new()
    {
        public T[] Sort(T[] array)
        {
	        // if array has only zero or one element, it is already sorted
	        if(array.Length <= 1)
	        {
                return array;
	        }

            T[] aux = new T[array.Length];
            Sort(array, aux, 0, array.Length-1);

            return array;

        }

        private void Sort(T[] array, T[] aux, int left, int right)
        {
            if (right <= left)
                return;

            int middle = left + (right - left) / 2;

            Sort(array, aux, left, middle);
            Sort(array, aux, middle + 1, right);
            Merge(array, aux, left, middle, right);
        }

        private void Merge(T[] array, T[] aux, int left, int middle, int right)
        {
            for (int k = left; k <= right; k++)
                aux[k] = array[k];

            int i = left;
            int j = middle+1;

            for (int k = left; k <= right; k++)
            {
                if (i > middle)
                    array[k] = aux[j++];
                else if (j > right)
                    array[k] = aux[i++];
                else if (aux[i].CompareTo(aux[j]) <= 0)
                    array[k] = aux[i++];
                else
                    array[k] = aux[j++];
            }
        }
    }
}

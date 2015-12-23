using System;

namespace AaDS.Sorting 
{
    /// <summary>
    /// Merge sort algorithm
    ///  Θ(n * log(n))
    /// </summary>
    public class MergeSort<T> : ISort<T> where T : IComparable, new()
    {
        public T[] Sort(T[] array)
        {
	        // if array has only zero or one element, it is already sorted
	        if(array.Length <= 1)
	        {
                return array;
	        }

            return Sort(array, 0, array.Length-1);

        }

        private T[] Sort(T[] array, int left, int right)
        {
            int middle = (int) (right + left) / 2;

            if (left < right)
            {
                Sort(array, left, middle);
                Sort(array, middle + 1, right);
            }

            T[] leftArray = new T[middle - left + 1];
            T[] rightArray = new T[right - middle];

            Array.Copy(array, left, leftArray, 0, middle - left + 1);
            Array.Copy(array, middle + 1, rightArray, 0, right - middle);

            return Merge(array, leftArray, rightArray);
        }

        private T[] Merge(T[] array, T[] leftArray, T[] rightArray)
        { 
            int i = 0;
            int j = 0;
            for (int k = 0; k < (leftArray.Length - 1) + (rightArray.Length - 1); k++)
            {
                if (i == leftArray.Length)
                {
                    array[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i].CompareTo(rightArray[j]) <= 0)
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
            }

            return array;
        }
    }
}

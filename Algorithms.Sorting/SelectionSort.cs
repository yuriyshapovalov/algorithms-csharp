using System;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Selection algorithm
    ///  https://en.wikipedia.org/wiki/Selection_sort
    ///  
    ///  Method: Selection
    ///  Stable: No
    ///  Worst case performance: O(n^2)
    ///  Best case performance: Ω(n^2)
    ///  Average case performance: O(n^2)
    ///  Worst space complexity: O(1)
    /// </summary>
    public class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            // for all elements in array
            for(int i = 0; i <= array.Length; i++)
            {
                // assume that element under cursor element is minimal 
                // (everything left should be already sorted)
                int min = i; 

                // for all following elements after cursor (find the minimal in sub array)
                for(int j = i; j < array.Length; j++)
                {
                    // if element on 'j' position is less that element on 'min' position
                    if (array[min].CompareTo(array[j]) > 0) // array[min] > array[j]
                    {
                        // change reference to 'min' position
                        min = j;
                    }
                }

                // if current element 'i' is not minimal
                if(min != i)
                {
                    // change value of current element and minimal element
                    T temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }       
            }
        }
    }
}

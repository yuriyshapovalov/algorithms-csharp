using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Sorting;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 0, 4, 1, 7, 8, 5, 423, 234, 4, 23, 12, 1, 4, 9 , 243892, 2 };
            Console.WriteLine(string.Join(", ", arr));
            MergeSort<int> sorter = new MergeSort<int>();
            int[] arr2 = sorter.Sort(arr);
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine(string.Join(", ", arr2));
            Console.ReadKey();
        }
    }
}

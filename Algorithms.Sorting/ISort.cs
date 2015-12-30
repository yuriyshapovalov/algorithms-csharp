using System;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Define general sorting methods
    /// Generic container for types implemented IComparable, with no parameter constructor
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISort<T> where T : IComparable<T>
    {
        T[] Sort(T[] array);
    }

}

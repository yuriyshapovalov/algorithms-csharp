using System;

namespace AaDS.Sorting
{
    /// <summary>
    /// Declare common methods for concrete sorting algorithms implementations
    /// Generic container for types implements IComparable, with no parameter constructor
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISort<T> where T : IComparable
    {
        T[] Sort(T[] array);
    }

}


namespace AaDS.Lists
{
    public class LinkedListArray<T>
    {
        private T[] _array;
        private const int _defaultArraySize = 100;

        public LinkedListArray()
        {
            _array = new T[_defaultArraySize];
        }

        public LinkedListArray(T array)
        {

        }
    }
}

namespace AaDS.Lists
{
    public class LinkedListExt<T>
    {
        private Node _first;
        private int _length;

        private class Node
        {
            T value;
            Node Next;
        }

        public LinkedListExt()
        {
            _first = new Node();
        }

        public void Add(T value)
        { 
            // 
        }

        public void Clear()
        {
            this._first = null;
        }

        public int Length { get { return this._length; } }

        public void Remove(int index)
        {
            
        }


    }
}
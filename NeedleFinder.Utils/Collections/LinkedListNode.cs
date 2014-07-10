namespace NeedleFinder.Utils.Collections
{
    public class LinkedListNode<T>
    {
        public T data;
        public LinkedListNode<T> next;
        public LinkedListNode(T value)
        {
            this.data = value;
        }
    }
}
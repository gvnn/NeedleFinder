namespace NeedleFinder.Utils.Collections
{
    public class LinkedList<T>
    {
        LinkedListNode<T> listHead;
        LinkedListNode<T> currentNode;
        int size;

        public void Add(LinkedListNode<T> node)
        {
            if (listHead == null)
            {
                listHead = node;
                currentNode = listHead;
            }
            else
            {
                currentNode.next = node;
                currentNode = currentNode.next;
            }
            size++;
        }

        public T[] ToArray()
        {
            T[] array = new T[size];
            int arrayIndex = 0;
            while (listHead != null)
            {
                array[arrayIndex] = listHead.data;
                listHead = listHead.next;
                arrayIndex++;
            }
            return array;
        }
    }
}
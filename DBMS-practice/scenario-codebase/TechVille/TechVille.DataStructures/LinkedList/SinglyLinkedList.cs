namespace TechVille.DataStructures.LinkedList
{
    public class SinglyLinkedList<T>
    {
        class Node { public T Data; public Node Next; }

        private Node head;

        public void Add(T data)
        {
            Node node = new Node { Data = data, Next = head };
            head = node;
        }
    }
}

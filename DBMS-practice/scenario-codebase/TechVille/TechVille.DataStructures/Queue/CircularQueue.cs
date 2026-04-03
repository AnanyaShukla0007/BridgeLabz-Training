namespace TechVille.DataStructures.Queue
{
    public class CircularQueue<T>
    {
        private T[] items;
        private int front = 0, rear = 0, size = 0;

        public CircularQueue(int capacity)
        {
            items = new T[capacity];
        }

        public void Enqueue(T item)
        {
            items[rear] = item;
            rear = (rear + 1) % items.Length;
            size++;
        }

        public T Dequeue()
        {
            T item = items[front];
            front = (front + 1) % items.Length;
            size--;
            return item;
        }
    }
}

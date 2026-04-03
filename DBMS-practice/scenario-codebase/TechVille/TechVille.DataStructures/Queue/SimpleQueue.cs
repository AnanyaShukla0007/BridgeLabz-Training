namespace TechVille.DataStructures.Queue
{
    public class SimpleQueue<T>
    {
        private T[] items;
        private int front = 0;
        private int rear = -1;
        private int count = 0;

        public SimpleQueue(int size)
        {
            items = new T[size];
        }

        public void Enqueue(T item)
        {
            if (count == items.Length)
                return;

            rear++;
            items[rear] = item;
            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
                return default;

            T item = items[front];
            front++;
            count--;
            return item;
        }
    }
}

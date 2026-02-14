using System.Collections.Generic;

namespace TechVille.DataStructures.Queue
{
    public class PriorityQueue<T>
    {
        private SortedList<int, T> data = new SortedList<int, T>();

        public void Enqueue(int priority, T item)
        {
            data.Add(priority, item);
        }

        public T Dequeue()
        {
            T item = data.Values[0];
            data.RemoveAt(0);
            return item;
        }
    }
}

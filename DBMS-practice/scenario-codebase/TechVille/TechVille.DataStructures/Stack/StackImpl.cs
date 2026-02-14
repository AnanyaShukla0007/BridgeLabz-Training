using System.Collections.Generic;

namespace TechVille.DataStructures.Stack
{
    public class StackImpl<T>
    {
        private Stack<T> stack = new Stack<T>();

        public void Push(T item) => stack.Push(item);
        public T Pop() => stack.Pop();
        public int Count => stack.Count;
    }
}

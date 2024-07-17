using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Objects
{
    public class Stack<T>
    {
        private LinkedList<T> List = new LinkedList<T>();


        public void Push(T item)
        {
            List.AddFirst(item);
        }


        public T Get()
        {
            if (List.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            T value = List.First.Value;
            List.RemoveFirst();
            return value;
        }
    }
}

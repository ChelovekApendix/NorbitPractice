using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Task
{
    public class SmartStack<T> : IEnumerable<T>
    {
        private T[] _array;
        private int _count;
        public int Count { get { return _count; } }
        public int Capacity { get { return _array.Length; } }

        public SmartStack() : this(4)
        {
        }

        public SmartStack(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentException("Нельзя задать отрицательный размер стека");
            _array = new T[capacity];
            _count = 0;
        }

        public SmartStack(IEnumerable<T> collection)
        {
            var array = collection.ToArray();
            _array = new T[array.Length];
            _count = array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[array.Length - 1 - i];
            }
        }

        public void Push(T item)
        {
            if (Count == _array.Length)
            {
                Resize(_array.Length * 2);
            }
            _array[_count] = item;
            _count++;
        }

        public void PushRange(IEnumerable<T> collection)
        {
            if (_count == 0)
                throw new InvalidOperationException("Стек пуст");
            var items = collection.ToArray();
            if (items.Length == 0) return;

            items.Reverse();

            int newCount = _count + items.Length;
            if (newCount > _array.Length)
            {
                int newCapacity = _array.Length;
                while (newCapacity < newCount)
                {
                    newCapacity *= 2;
                }
                Resize(newCapacity);
            }

            for (int i = 0; i < items.Length; i++)
            {
                _array[_count + i] = items[i];
            }
            _count = newCount;
        }

        public T Pop()
        {
            if (_count == 0)
                throw new InvalidOperationException("Стек пуст");

            _count--;
            T item = _array[_count];
            _array[_count] = default(T);
            return item;
        }

        public T Peek()
        {
            if (_count == 0)
                throw new InvalidOperationException("Стек пуст");

            return _array[_count - 1];
        }

        public bool Contains(T item)
        {
            EqualityComparer<T> comparer = EqualityComparer<T>.Default;
            for (int i = 0; i < _count; i++)
            {
                if (comparer.Equals(_array[i], item))
                    return true;
            }
            return false;
        }

        private void Resize(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            Array.Copy(_array, 0, newArray, 0, _count);
            _array = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                yield return _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            if (_count == 0) return "Стек пуст";

            var items = new StringBuilder();
            items.Append("[");
            for (int i = _count - 1; i >= 0; i--)
            {
                items.Append(_array[i]);
                if (i > 0) items.Append(", ");
            }
            items.Append("]");
            return items.ToString();
        }
    }
}

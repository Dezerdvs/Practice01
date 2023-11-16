using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    public class MyArray<T>
    {
        private T[] items;

        public MyArray()
        {
            Items = Array.Empty<T>();
        }

        public MyArray(int size)
        {
            Items = new T[size];
        }

        public override string ToString()
        {
            return string.Join(" ", Items);
        }

        public string GetAllArrayAsString() => ToString();

        public string GetElementAsString(int index) => this[index].ToString();

        public T this[int index]
        {
            get
            {
                ValidateIndex(index);
                return Items[index];
            }
            set
            {
                ValidateIndex(index);
                Items[index] = value;
            }
        }

        public T[] Items
        {
            get => items;
            private set
            {
                items = value ?? Array.Empty<T>();
                Count = items.Length;
            }
        }

        public int Count { get; private set; }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range [0, {Count - 1}].");
            }
        }
    }
}

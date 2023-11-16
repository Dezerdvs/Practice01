using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    public class Array2D<T>
    {
        private T[,] array;

        public Array2D() : this(new T[0, 0]) { }

        public Array2D(int size) : this(new T[size, size]) { }

        public Array2D(int sizeA, int sizeB) : this(new T[sizeA, sizeB]) { }

        private Array2D(T[,] array)
        {
            MyArray = array;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < LengthA; i++)
            {
                for (int j = 0; j < LengthB; j++)
                {
                    result.Append(array[i, j]);
                    result.Append(j < LengthB - 1 ? " " : "");
                }
                result.AppendLine(i < LengthA - 1 ? "" : "");
            }
            return result.ToString();
        }


        public string GetAllArrayAsString()
        {
            return ToString();
        }

        public string GetElementAsString(int indexI, int indexJ)
        {
            return this[indexI, indexJ].ToString();
        }

        public T this[int indexI, int indexJ]
        {
            get
            {
                ValidateIndices(indexI, indexJ);
                return array[indexI, indexJ];
            }
            set
            {
                ValidateIndices(indexI, indexJ);
                array[indexI, indexJ] = value;
            }
        }

        public T[,] MyArray
        {
            get { return array; }
            private set
            {
                array = value;
                UpdateLengths();
            }
        }

        public int LengthA { get; private set; }
        public int LengthB { get; private set; }

        private void UpdateLengths()
        {
            LengthA = array.GetLength(0);
            LengthB = array.GetLength(1);
        }

        private void ValidateIndices(int indexI, int indexJ)
        {
            if (indexI < 0 || indexI >= LengthA || indexJ < 0 || indexJ >= LengthB)
                throw new IndexOutOfRangeException($"Index [{indexI}, {indexJ}] out of range [{LengthA}, {LengthB}]!");
        }
    }
}

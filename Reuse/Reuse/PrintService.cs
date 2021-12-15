using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reuse
{
    class PrintService<T> ///// modificated for reuse
    {
        private T[] _values = new T[10]; ///// modificated for reuse
        private int _count = 0;

        public void addValue(T value) ///// modificated for reuse
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService Cheio");
            }
            _values[_count] = value;
            _count++;
        }


        public T First() ///// modificated for reuse
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService Vazio");
            }
            return (_values[0]);
        }

        public void Print()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService Vazio");
            }
            Console.Write("[");
            for (int count = 0; count < (_count - 1); count++)
            {
                Console.Write(_values[count].ToString() + ", ");
            }
            Console.Write(_values[(_count - 1)]);
            Console.Write("]");
        }
    }
}

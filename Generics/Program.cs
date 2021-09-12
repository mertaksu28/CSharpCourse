using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
        }
    }

    class MyList<T>
    {
        T[] _array;

        public MyList()
        {
            _array = new T[0]; 
        }

        public void Add(T item)
        {

        }
    }
}

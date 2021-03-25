using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class MyList<Type>
    {
        Type[] array;

        public MyList()
        {
            array = new Type[0];
        }

        public void Add(Type value)
        {
            Type[] temp = array;

            array = new Type[array.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                array[i] = temp[i];
            }

            array[array.Length - 1] = value;
        }

        public int Length => array.Length;

        public Type[] Items => array;
    }
}

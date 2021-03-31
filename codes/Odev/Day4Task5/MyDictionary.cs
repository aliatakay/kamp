using System;
using System.Collections.Generic;
using System.Text;

namespace Day4Task5
{
    public class MyDictionary<TKey, TVal>
    {
        TKey[] keys;
        TVal[] values;

        TKey[] tempKeys;
        TVal[] tempValues;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TVal[0];
        }

        public void Add(TKey key, TVal value)
        {
            tempKeys = keys;
            tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TVal[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[^1] = key;
            values[^1] = value;
        }

        public int Length => keys.Length;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class Dictionary<TKey,TValue>
    {
        TKey[] KeyArray;
        TValue[] ValueArray;

        TKey[] tempKeyArray;
        TValue[] tempValueArray;

        public Dictionary()
        {
            KeyArray = new TKey[0];
            ValueArray = new TValue[0];

        }

        public void Add(TKey key, TValue value)
        {
            tempKeyArray = KeyArray;
            tempValueArray = ValueArray;

            KeyArray = new TKey[KeyArray.Length + 1];
            ValueArray = new TValue[ValueArray.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                KeyArray[i] = tempKeyArray[i];
            }

            for (int i = 0; i < tempValueArray.Length; i++)
            {
                ValueArray[i] = tempValueArray[i];
            }

            KeyArray[KeyArray.Length - 1] = key;
            ValueArray[ValueArray.Length - 1] = value;


        }

        public TKey[] Items1
        {
            get { return KeyArray; }
        }

        public TValue[] Items2
        {
            get { return ValueArray; }
        }

    }
}

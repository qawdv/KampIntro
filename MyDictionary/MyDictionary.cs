using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[]  keys;
        TValue[]  values;

        public MyDictionary() 
        {
            keys = new TKey[0];
            values = new TValue[0];            
        }
        public void Add(TKey key,TValue value) 
        {
            TKey[] tempKey = keys;
            TValue[] tempValue = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;                       
        }                     

        public void PrintAll()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("key :" + keys[i] +" "+ "value :" + values[i]);
                Console.WriteLine("-------------------------------");
                Console.WriteLine();
            }
        }

        public TKey[] Items1 
        {
            get { return keys; }             
        }

        public TValue[] Items2
        {
            get { return values; }
        }

        public int MyLength
        {
            get { return keys.Length; }
        }

    }
}

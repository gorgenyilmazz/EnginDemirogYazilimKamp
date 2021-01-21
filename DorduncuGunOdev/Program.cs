using System;
using System.Collections.Generic;

namespace DorduncuGunOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sozluk = new MyDictionary<int, string>();

            sozluk.Add(1, "Elma");
            sozluk.Add(2, "Armut");
            sozluk.Add(3, "Kiraz");

            Console.WriteLine(sozluk.KeyCount());
            Console.WriteLine(sozluk.ValueCount());

            for (int i = 0; i < sozluk.KeyCount(); i++)
            {
                Console.WriteLine(sozluk.GetKeys[i]);

            }

            for (int i = 0; i < sozluk.ValueCount(); i++)
            {
                Console.WriteLine(sozluk.GetValues[i]);

            }


        }
    }

    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary() {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value) {

            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public int KeyCount() {
            return keys.Length;
        }
        public int ValueCount()
        {
            return values.Length;
        }
        public TKey[] GetKeys { get { return keys; } }
        public TValue[] GetValues { get { return values; } }

    }
}

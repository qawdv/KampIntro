//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Dictionary
//{
//    class MyDictionary<T>
//    {
//        T[] Kelimeler;
//        public MyDictionary()
//        {
//            Kelimeler = new T[0];
//        }
//        public void Add(T Kelime)
//        {
//            T[] tempArray = Kelimeler;
//            Kelimeler = new T[Kelimeler.Length + 1];

//            for (int i = 0; i < tempArray.Length; i++)
//            {
//                Kelimeler[i] = tempArray[i];
//            }

//            Kelimeler[Kelimeler.Length - 1] = Kelime;

//        }

//    }
//}


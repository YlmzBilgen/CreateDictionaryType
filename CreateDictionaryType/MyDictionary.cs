using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreateDictionaryType
{
    public class MyDictionary<T1,T2>
    {
        private T1[] keyArray;
        private T2[] valueArray;
        private MyDictionaryItem<T1, T2>[] myDictionaryItems;
        public MyDictionary()
        {
            keyArray = new T1[0];
            valueArray = new T2[0];
            myDictionaryItems = new MyDictionaryItem<T1, T2>[0];
        }

        /// <summary>
        /// Use for add item to dictionary
        /// </summary>
        /// <param name="keyParameter"></param>
        /// <param name="valueParameter"></param>
        public void Add(T1 keyParameter, T2 valueParameter)
        {
            T1[] tempKeyArray = keyArray;
            T2[] tempValueArray = valueArray;
            MyDictionaryItem<T1, T2>[] tempMyDictionaryItems = myDictionaryItems;

            keyArray = new T1[keyArray.Length + 1];
            valueArray = new T2[valueArray.Length + 1];
            myDictionaryItems = new MyDictionaryItem<T1, T2>[myDictionaryItems.Length + 1];

            for (int i = 0; i < tempMyDictionaryItems.Length; i++)
            {
                keyArray[i] = tempKeyArray[i];
                valueArray[i] = tempValueArray[i];
                myDictionaryItems[i] = tempMyDictionaryItems[i];
            }

            keyArray[keyArray.Length - 1] = keyParameter;
            valueArray[valueArray.Length - 1] = valueParameter;
            myDictionaryItems[myDictionaryItems.Length - 1] = new MyDictionaryItem<T1, T2>(keyParameter, valueParameter);
        }

        /// <summary>
        /// Return Dictionary Items for that if you want to loop Dictionary Item 
        /// </summary>
        public MyDictionaryItem<T1, T2>[] Items 
        {
            get
            {
                return myDictionaryItems;
            }
        }

        /// <summary>
        /// Return dictinoary Lenght
        /// </summary>
        private int lenght;
        public int Lenght
        {
            get { return keyArray.Length; }     
        }

        /// <summary>
        /// For getting value with index
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public T2 this[int key] 
        {
            get
            {
                return valueArray[key];
            } 
            
            set 
            {
                valueArray[key] = value;
            } 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CreateDictionaryType
{
    public class MyDictionaryItem<T1, T2>
    {
        public T1 Key { get; set; }
        public T2 Value { get; set; }

        public MyDictionaryItem()
        {

        }
        public MyDictionaryItem(T1 keyParam, T2 valueParam)
        {
            Key = keyParam;
            Value = valueParam;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryIntro
{
    class MyDictionary<TKey, TValue> //for generic types
    {
        TKey[] keys;
        TValue[] values;
       
        //constructor block
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeyArray = keys; //temporarily we referenced array items to tempKeyArray since in below we will use new function (wil be new reference) which it will delete old entries in the keys array 
            keys = new TKey[keys.Length + 1]; //we should increase array element number as dynamic
            
            TValue[] tempValueArray = values; //temporarily we referenced array items to tempKeyArray since in below we will use new function (wil be new reference) which it will delete old entries in the keys array 
            values = new TValue[values.Length + 1]; //we should increase array element number as dynamic
            
            //now we will handover old entries from tempKeyArray
            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keys[i] = tempKeyArray[i];
                values[i] = tempValueArray[i];
            }

            keys[keys.Length - 1] = key; //Now we can add the new and last key in here
            values[values.Length - 1] = value; //Now we can add the new and last key in here

            Console.WriteLine("New Project Added: " + key + "-" + value);
        }


    }
}

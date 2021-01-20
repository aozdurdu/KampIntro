using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //for generic types
    {
        T[] items;
        //constructor block
        public MyList()
        {
            items = new T[0];
        }
        public void Add (T item)
        {
            T[] tempArray = items; //temporarily we referenced array items to tempArray since in below we will use new function (wil be new reference) which it will delete old entries in the items array 
            items = new T[items.Length + 1]; //we should increase array element number as dynamic

            //now we will handover old entries from tempArray
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //Now we can add the new and last item in here
        }

    }
}

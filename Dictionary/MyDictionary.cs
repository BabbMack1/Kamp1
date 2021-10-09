using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDictionary<T,K>
    {
        T[] keyArray;
        K[] valueArray;

        public MyDictionary()
        {
            keyArray = new T[0];
            valueArray = new K[0];
        }
        public void Add(T key,K value)
        {
            T[] tempKey = keyArray;
            K[] tempValue = valueArray;
            keyArray = new T[keyArray.Length+1];
            valueArray = new K[valueArray.Length+1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keyArray[i] = tempKey[i];
                valueArray[i] = tempValue[i];
            }
            keyArray[keyArray.Length-1] = key;
            valueArray[valueArray.Length-1] = value;
        }
        public void ShowArray()
        {
            Console.WriteLine("KEY-VALUE");
            if (keyArray != null)
            {


                for (int i = 0; i < keyArray.Length; i++)
                {
                    Console.WriteLine(keyArray[i] + ":" + valueArray[i]);
                }
            }
            else
            {
                Console.WriteLine("Dictionary is empty");
            }
        }
        public void ShowSize()
        {
            if (keyArray!= null)
            {


                Console.WriteLine("Key size: " + keyArray.Length + " Value size: " + valueArray.Length);
            }
        }
    }
}

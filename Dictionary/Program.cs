using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> MyDict = new MyDictionary<string, int>();
            MyDict.ShowArray();
            MyDict.ShowSize();
            MyDict.Add("Mahmut", 22);
            MyDict.Add("Kemal", 20);
            MyDict.Add("Hasan", 30);
            MyDict.ShowArray();
            MyDict.ShowSize();


        }
    }
}

using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Class1
    {
        public void Test()
        {
            var list = new List<int>
            {
                1, 2, 4, 8, 16
            };

            int index;
            Wintellect.PowerCollections.Algorithms.BinarySearch(list, 4, out index);

            Console.WriteLine(index);
        }
    }
}

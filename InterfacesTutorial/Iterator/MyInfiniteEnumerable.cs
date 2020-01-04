using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTutorial.Iterator
{
    public class MyInfiniteEnumerable : IEnumerable<int>
    {
        int[] mMyData = new int[] { 1, 5, 7, 8, 9, 24 };
        public IEnumerator GetEnumerator()
        {
            return new MyInfiniteEnumerator(mMyData);
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return new MyInfiniteEnumerator(mMyData);
        }
    }
}

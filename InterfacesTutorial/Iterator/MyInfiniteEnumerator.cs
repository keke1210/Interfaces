using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTutorial.Iterator
{
    public class MyInfiniteEnumerator : IEnumerator<int>
    {
        private int[] mValues;

        private int mIndex = -1;
        public int Current => mValues[mIndex];
        object IEnumerator.Current => Current;

        // Constructor
        public MyInfiniteEnumerator(int[] values)
        {
            mValues = values;
        }

        public bool MoveNext()
        {
            mIndex++;

            return mIndex < mValues.Length;
        }

        public void Reset()
        {
            mIndex = 0;
        }

        public void Dispose()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class BucketSort
    {
        /// <summary>
        /// Method which calls the pop and load method from the stack and queue classes, 
        /// then copies the sorted array back into the droid collection.
        /// </summary>
        /// <param name="droidCollection"></param>
        public static void Sort(IDroid[] droidCollection)
        {
            int i = 0;

            Stack.Pop(droidCollection);
            Queue.Load();

            foreach (IDroid droid in Queue.sortedCollection)
            {
                droidCollection[i] = droid;
                i++;
            }
        }
    }
}

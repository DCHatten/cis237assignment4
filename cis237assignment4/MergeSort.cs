using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort : IComparable
    {
        private IDroid[] tempCollection;

        public MergeSort(int sizeOfCollection)
        {
            //Make new array for the collection
            tempCollection = new IDroid[sizeOfCollection];
        }

        private static void merge(IDroid[] droidCollection, IDroid[] tempCollection, int lo, int mid, int hi)
        {
            for (int k = lo; k <= hi; k++)
            {
                //Copy the passed in droid collection to the temp collection for sorting
                tempCollection[k] = droidCollection[k];
            }
            //Setting variables to use during the sort to step through the array
            int i = lo;
            int j = mid + 1;

        }

        private static void sort(IDroid[] droidCollection, IDroid[] tempCollection, int lo, int hi)
        {
            //Do the Sort
        }

        public int CompareTo(object obj)
        {
            //Do the Comparison
            if (obj != null) {
                return this.CompareTo(obj);
            }
            //Throw exceptions as needed
            else {
                throw new Exception("Item is not a Droid");
            }
        }
    }
}

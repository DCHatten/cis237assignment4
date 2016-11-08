                                                                                                          using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort : IComparable
    {
        /// <summary>
        /// This is the main method, which will be called by other classes to implement the merge sort
        /// </summary>
        /// <param name="droidCollection"></param>
        public static void SortAndMerge(IDroid[] droidCollection)
        { 
            //Setting the max variable which will be passed into the sort method
            int hi = droidCollection.Length - 1;
            //Calling the sort method which will recursively split the array into smaller pieces
            sort(droidCollection, 0, hi);
        }
        /// <summary>
        /// Sort method which uses recursion to split the array into smaller pieces until it can be merged
        /// </summary>
        /// <param name="droidCollection"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        private static void sort(IDroid[] droidCollection, int lo, int hi)
        {
            //Base case check
            if (hi - lo >= 1)
            {
                //Setting the midpoint of the array in use
                int mid = (lo + hi) / 2;
                //Recursively calling the method on the left half of the array
                sort(droidCollection, lo, mid);
                //Recursively calling the method on the right half of the array
                sort(droidCollection, mid + 1, hi);
                //Calling the merge method to run the comparisons and merge the arrays back together
                merge(droidCollection, lo, mid, hi);
            }

        }
        /// <summary>
        /// This merge method will use the properties of IComparable to compre two droids based on total cost and then
        /// merge the arrays back together in sorted order
        /// </summary>
        /// <param name="droidCollection"></param>
        /// <param name="lo"></param>
        /// <param name="mid"></param>
        /// <param name="hi"></param>
        private static void merge(IDroid[] droidCollection, int lo, int mid, int hi)
        {
            //Declaring the temporary array for storing sorted values
            IDroid[] tempCollection = new IDroid[droidCollection.Length];
            //Setting indeces for the original and temp array for stepping through each part individually
            int leftIndex = lo;
            int rightIndex = mid + 1;
            int tempIndex = lo;
            //While loop to maintain the method until all objects have been compared
            while (leftIndex <= mid && rightIndex <= hi)
            {
                //Compare the two objects then place them into the temporary array as sorted
                if ((CompareTo(droidCollection, leftIndex, mid)) == 1)
                {
                    tempCollection[tempIndex++] = droidCollection[lo++];
                }
                else
                {
                    tempCollection[tempIndex++] = droidCollection[mid++];
                }
                if (leftIndex == rightIndex)
                {
                    mid = mid++;
                    while (rightIndex <= hi)
                    {
                        
                        if ((CompareTo(droidCollection, lo, mid)) == 1)
                        {
                            tempCollection[tempIndex++] = droidCollection[rightIndex++];
                        }
                        else
                        {
                            tempCollection[tempIndex++] = droidCollection[mid++];
                        }
                    }
                }
            }
            for (int k = 0; k < tempCollection.Length; k++)
            {
                droidCollection[k] = tempCollection[k];
            }
        }
        /// <summary>
        /// This CompareTo method is an overload of the stock method which will compare two droids from a
        /// droid collection based on their total cost property and return an int indicating the result of the comparison
        /// </summary>
        /// <param name="droidCollection"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        /// <returns></returns>
        public static int CompareTo(IDroid[] droidCollection, int lo, int hi)
        {
            //Setting the result int
            int result = 0;
            //Do the Comparison
            if (droidCollection[lo].TotalCost <= droidCollection[hi].TotalCost)
            {
                //Set the result to the true condition
                result = 1;
                //return true condition
                return result;
             }
             else
             {
                //return the false condition
                return result;
             }
        }
        /// <summary>
        /// This is the stock CompareTo method, which is not used in this program
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}

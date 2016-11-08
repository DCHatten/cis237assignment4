using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Queue
    {
        //Declaring a class level array which will house the sorted array until it 
        //can be copied back to the collection for display
        public static IDroid[] sortedCollection = new IDroid[1000];
        /// <summary>
        /// Method which pulls each stack and puts it into the sorted collection in order of model
        /// </summary>
        public static void Load()
        {
            int i = 0;
            foreach (IDroid droid in Stack.AstromechStack)
            {
                sortedCollection[i] = droid;
                i++;
            }
            foreach (IDroid droid in Stack.JanitorStack)
            {
                sortedCollection[i] = droid;
                i++;
            }
            foreach (IDroid droid in Stack.ProtocolStack)
            {
                sortedCollection[i] = droid;
                i++;
            }
            foreach (IDroid droid in Stack.UtilityStack)
            {
                sortedCollection[i] = droid;
                i++;
            }
            //Calls the private Remove Null method to shorten the collection to just usable data
            sortedCollection = RemoveNull(sortedCollection);
        }
        /// <summary>
        /// Method which steps through the passed in collection and only returns an array with usable data
        /// in each cell
        /// </summary>
        /// <param name="droidCollection"></param>
        private static IDroid[] RemoveNull(IDroid[] droidCollection)
        {
            IDroid[] temp = new IDroid[1];
            int i = 0;
            foreach (IDroid droid in droidCollection)
            {
                if (droid != null)
                {
                    if (i < temp.Length)
                    {
                        temp[i] = droid;
                        i++;
                    }
                    else
                    {
                        Array.Resize<IDroid>(ref temp, temp.Length + 1);
                        temp[i] = droid;
                        i++;
                    }
                }
            }
            droidCollection = new IDroid[temp.Length];
            for (int k = 0; k < temp.Length; k++)
            {
                droidCollection[k] = temp[k];
            }
            return droidCollection;
        }
    }
}

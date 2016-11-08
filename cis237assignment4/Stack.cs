using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Stack
    {
        //Setting up public stacks that will be used to sort the droids by type
        public static IDroid[] AstromechStack = new IDroid[100];
        public static IDroid[] JanitorStack = new IDroid[100];
        public static IDroid[] ProtocolStack = new IDroid[100];
        public static IDroid[] UtilityStack = new IDroid[100];
        /// <summary>
        /// Method which accepts the droid collection, then pops droids into their proper stack based
        /// on the model property of the droid classes.  This uses Polymorphism and inheritance to get
        /// model from each classes individual Model property.
        /// </summary>
        /// <param name="droidCollection"></param>
        public static void Pop(IDroid[] droidCollection)
        {
            //Delcaring counters for each stack and the collection
            int i = 0;
            int a = 0;
            int j = 0;
            int p = 0;
            int u = 0;
            //Loop which steps through the droid collection and pops the droids into their stacks.
            //This uses a temporary string variable to run a switch statment for sorting.
            foreach (IDroid droid in droidCollection)
            {
                string model = droid.Model;
                switch (model)
                {
                    case "AstromechDroid":
                        AstromechStack[a] = droidCollection[i];
                        i++;
                        a++;
                        break;
                    case "JanitorDroid":
                        JanitorStack[j] = droidCollection[i];
                        i++;
                        j++;
                        break;
                    case "ProtocolDroid":
                        ProtocolStack[p] = droidCollection[i];
                        i++;
                        p++;
                        break;
                    case "UtilityDroid":
                        UtilityStack[u] = droidCollection[i];
                        i++;
                        u++;
                        break;
                    default:
                        throw new Exception("Droid is not of a valid type");
                }
            }
            //Calling the private remove null method to shorten each stack to just the usable data
            AstromechStack = RemoveNull(AstromechStack);
            JanitorStack = RemoveNull(JanitorStack);
            ProtocolStack = RemoveNull(ProtocolStack);
            UtilityStack = RemoveNull(UtilityStack);
        }
        /// <summary>
        /// Method to remove null values from the individual stacks prior to loading them into the queue
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

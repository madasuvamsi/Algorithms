using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //input 1
            //int[] sampleArray = new int[4] { 1, 2, 3, 1 };

            //input 2
            int[] sampleArrayTwo = new int[4] { 1, 2, 3, 4 };

            bool result = ContainsDups(sampleArrayTwo);

            if(result==true)
            {
                Console.WriteLine("The array contains duplicate elements");
            }
            else
            {
                Console.WriteLine("There are no duplciate elemts in the array");
            }
        }

        /*Time Complexity for this will be O(n) and 
         * Space complexity is O(n) as we are using a hashset*/
        public static bool ContainsDups(int[] arr)
        {
            /*
             The HashSet<T> class provides high-performance set operations. 
             A set is a collection that contains no duplicate elements,
             and whose elements are in no particular order.
             */

            HashSet<int> numbers = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if(numbers.Contains(arr[i]))
                {
                    return true;
                }
                else
                {
                    //Add integers to mumbers hashset if they are not already present in the hashset
                    numbers.Add(arr[i]);
                }
            }

            //If no dups are present return false
            return false;
        }
    }
}

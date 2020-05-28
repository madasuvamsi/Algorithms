using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCheck
{
    class DupCheckMethodTwo
    {
        public static void Main(string[] args)
        {
            int[] sampleArray = new int[4] { 1, 2, 3, 4 };

            bool result = DupCheck(sampleArray);
            if (result == true)
            {
                Console.WriteLine("The array contains duplicate elements");
            }
            else
            {
                Console.WriteLine("There are no duplciate elemts in the array");
            }
        }


        /*
         Array.Sort() method uses quick sort
         On average, this method is an O(n log n) operation, where n is Count;
         in the worst case it is an O(n2) operation.

         The Time complexity for this alforithm is O(nlogn) for Average case
         and O(n2) for Worst case and the Space complexity is O(1)
             */

        public static bool DupCheck(int[] arr)
        {
            Array.Sort(arr);

            for (int i = 0; i < arr.Length-1; i++)
            {
                if(arr[i]==arr[i+1])
                {
                    return true;
                }
            }

            return false;
        }
    }
}

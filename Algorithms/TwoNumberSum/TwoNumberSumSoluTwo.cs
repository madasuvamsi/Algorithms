using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumberSum
{
    class TwoNumberSumSoluTwo
    {
        static void Main(string[] args)
        {
            int[] array = new int[8] { 3, 5, -4, 8, 11, 1, -1, 6 };//Initial Array
            int targetSum = 10;//Target Sum
            Array.Sort(array);
            int[] outputArray=new int[2];

            int left = 0;
            int right = array.Length - 1;
            while (left<right)
            {
                int currentSum = array[left] + array[right];
                if(currentSum==targetSum)
                {
                    outputArray[0] = array[left];
                    outputArray[1] = array[right];
                    left += 1;
                    right -= 1;
                }
                else if(currentSum<targetSum)
                {
                    left += 1;
                }
                else if(currentSum>targetSum)
                {
                    right -= 1;
                }
               
               
            }


            Console.WriteLine("The Output array is [{0},{1}]", outputArray[0], outputArray[1]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumberSum
{
    class TwoNumberSumSolThree
    {
        public static void Main(string[] args)
        {
            int[] array = new int[8] { 3, 5, 4, 8, 11, 1, -1, 6 };//Initial Array
            int targetSum = 10;//Target Sum
            int[] result = TwoNumberSum(array, targetSum);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

        }

        public static int[] TwoNumberSum(int[] array,int targetSum)
        {
            //int[] array = new int[8] { 3, 5, 4, 8, 11, 1, -1, 6 };//Initial Array
            HashSet<int> nums = new HashSet<int>();

            foreach (var value in array)
            {
                int potentialmatch = targetSum - value;
                if (nums.Contains(potentialmatch))
                {
                    return new int[] { potentialmatch, value };
                }
                else
                {
                    nums.Add(value);
                }
            }

            return new int[0];

        }
    }
}

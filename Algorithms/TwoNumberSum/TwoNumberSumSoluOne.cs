using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumberSum
{
    class TwoNumberSumSoluOne
    {
        static void Main(string[] args)
        {
            //Time Complexity O(n^2)
            //Space Complexity O(1)
            int[] array = new int[8] { 3, 5, -4, 8, 11, 1, -1, 6 };//Initial Array
            int targetSum = 10;//Target Sum
            Array.Sort(array);
            int[] outputArray = new int[2]; ;

            for (int i = 0; i < array.Length-1; i++)
            {
                int first = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    int second = array[j];
                    if(first+second==targetSum)
                    {
                        
                        outputArray[0] = first;
                        outputArray[1] = second;
                    }
                }
            }

            Console.WriteLine("The Output Array is [{0},{1}]", outputArray[0],outputArray[1]);


            
        }
        
    }
}

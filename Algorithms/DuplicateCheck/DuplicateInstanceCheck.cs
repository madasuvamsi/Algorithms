using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCheck
{
    class DuplicateInstanceCheck
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[9] { 1, 2, 3, 1, -1, 0, -2, 2, 3 };
            DupOccurance(nums);
            Console.ReadKey();
        }
        /*Time complexity for this algorithm is O(n) and Space complexity os O(n)
         * as we are creating a dictionary*/
        public static void DupOccurance(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var value in arr)
            {
                if (dict.ContainsKey(value))
                {
                    //This is similar to dict[value]=dict[value]+1(x++ is same as x=x+1)
                    dict[value]++;
                }
                else
                {
                    dict[value] = 1;
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine("{0} values occurs {1} times in the array", item.Key, item.Value);
            }
        }
    }
}

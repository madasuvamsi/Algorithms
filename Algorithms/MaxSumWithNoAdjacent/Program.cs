using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumWithNoAdjacent
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {75,100};
            if(numbers.Length==0)
            {
                Console.WriteLine("The Max sum is:{0} ", 0);
                
            }
            else
            {
                int incl = numbers[0];
                int excl = 0;
                for (int i = 1; i < numbers.Length; i++)
                {
                    int temp = incl;
                    incl = Math.Max(incl, excl + numbers[i]);
                    excl = temp;
                }
                Console.WriteLine("The Max sum is:{0} ", incl);
            }
            
        }
    }
}

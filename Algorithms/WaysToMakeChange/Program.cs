using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaysToMakeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] denominations = new int[2] { 1, 5 };
            int total = 6;
            int[] ways = new int[total + 1];
            ways[0] = 1;
            foreach (var denom in denominations)
            {
                for (int amount = 1; amount < total+1; amount++)
                {
                    if(denom<=amount)
                    {
                        ways[amount] += ways[amount - denom];
                    }
                }
            }
            int result = ways[total];
            Console.WriteLine("The result is {0}", result);
        }
    }
}

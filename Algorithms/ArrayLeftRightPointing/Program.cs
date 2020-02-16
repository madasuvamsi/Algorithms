using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLeftRightPointing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] samplearray = new int[] { -2, 10, 5, 1, -1, 6, 4 };
            int[] outputarray = new int[samplearray.Length];

            int left = 0;
            int right = samplearray.Length - 1;

            for (int i = 0; i < samplearray.Length; i++)
            {
                if(samplearray[left]<samplearray[right])
                {
                    outputarray[i] = samplearray[left];
                    left += 1;
                }
                else
                {
                    outputarray[i] = samplearray[right];
                    right -= 1;
                }
            }

            Console.WriteLine("The array before sorting is:");
            foreach (var item in samplearray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("The array after sorting is:");
            foreach (var item in outputarray)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}

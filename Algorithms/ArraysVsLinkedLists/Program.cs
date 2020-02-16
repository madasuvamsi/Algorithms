using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArraysVsLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode<string> sname = new LinkedListNode<string>("Sam");
            LinkedList<string> students = new LinkedList<string>();
            students.AddFirst(sname);
            students.AddLast("Nag");
            students.AddAfter(students.Find("Sam"), "Akhil");

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}

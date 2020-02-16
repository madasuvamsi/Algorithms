using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysVsLinkedLists
{
    class Node
    {
        int data;
        Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }


        public static void Main(string[] args)
        {

        }
    }
    class DNode
    {
        int data;
        DNode prev;
        DNode next;
        public DNode(int d)
        {
            data = d;
            next = null;
            prev=null;
        }

    }
}

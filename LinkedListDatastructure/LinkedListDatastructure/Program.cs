using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDatastructure
{
    /**
     * A LinkedList is a series of objects which instead of having their references indexed (like an Array), stay together by linking to each other, in Nodes.
     * 
     * A LinkedList Node has basically three values: the Object's Value, a reference to the Next node, and a reference to the Previous Node.
     * */

    class Program
    {
        static void Main(string[] args)
        {
            Node myNode = new Node(7);
            myNode.AddToEnd(5);
            myNode.AddToEnd(11);
            myNode.AddToEnd(4);
            myNode.Print();
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }

        public void Print()
        {
            Console.Write("|" + data + "|->");
            if(next != null)
            {
                next.Print();
            }
        }

        public void AddToEnd(int data)
        {
            if(next == null)
            {
                next = new Node(data);
            }
            else
            {
                // recursive call of AddToEnd
                next.AddToEnd(data);
            }
        }
    }
}
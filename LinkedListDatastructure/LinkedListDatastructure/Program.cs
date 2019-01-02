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
            //Node myNode = new Node(7);
            //myNode.AddToEnd(5);
            //myNode.AddToEnd(11);
            //myNode.AddToEnd(4);
            //myNode.AddToEnd(8);
            //myNode.Print();

            MyList list = new MyList();
            list.AddToEnd(9);
            list.AddToEnd(5);
            list.AddToEnd(7);
            list.AddToEnd(11);
            list.Print();
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
                // recursive call for Print
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

    public class MyList
    {
        public Node headNode;

        public MyList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }

        public void Print()
        {
            if(headNode != null)
            {
                headNode.Print();
            }
        }
    }
}
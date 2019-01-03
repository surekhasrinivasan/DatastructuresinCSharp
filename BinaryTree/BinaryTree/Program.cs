using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    // A Binary tree is a tree data structure in which each node has at most two child nodes, usually distinguished as "left" and "right".

    /** 
     * C# implentation of a very basic binary tree class demonstrating how to create the node and tree classes;
     * how to implement a recursive and non-recursive version of an add method and how to create a recursive
     * print method to output the tree in sorted order.
     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int initial)
        {
            value = initial;
            left = null;
            right = null;
        }
    }

    class Tree
    {
        Node top;

        public Tree()
        {
            top = null;
        }

        public Tree(int initial)
        {
            top = new Node(initial);
        }

        // Non-recursive add
        public void Add(int value)
        {
            if(top == null) // the tree is empty
            {
                // Add item as the base node
                Node newNode = new Node(value);
                top = newNode;
                return;
            }
            Node currentnode = top;
            bool added = false;
            do
            {
                // traverse tree
                if(value < currentnode.value)
                {
                    // go left 
                    if(currentnode.left == null)
                    {
                        // Add the item
                        Node NewNode = new Node(value);
                        currentnode.left = NewNode;
                        added = true;
                    }
                    else
                    {
                        currentnode = currentnode.left;
                    }
                }
                if(value >= currentnode.value)
                {
                    // go right 
                    if(currentnode.right == null)
                    {
                        // Add the item
                        Node NewNode = new Node(value);
                        currentnode.right = NewNode;
                        added = true;
                    }
                    else
                    {
                        // go right
                        currentnode = currentnode.right;
                    }
                }

            } while (!added);
        }

        // Recursive add
        public void AddRc(int value)
        {
            AddR(ref top, value);
        }

        // private recursive search for where to add the new node 
        private void AddR(ref Node N,int value)
        {
            
        }
        
        // Write out the tree in sorted order to the string newstring
        // implement using recursion
        public void Print(ref string newstring)
        {

        }
    }
}

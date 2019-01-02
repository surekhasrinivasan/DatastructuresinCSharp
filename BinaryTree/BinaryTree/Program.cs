﻿using System;
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
    }
}

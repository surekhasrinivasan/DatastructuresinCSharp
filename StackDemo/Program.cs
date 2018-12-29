using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDemo
{
    // Stack implementation using array in C#
    class Program
    {
        static void Main()
        {
            Stack S = new Stack(5);

            S.push(10);
            S.push(20);
            S.push(30);
            S.push(40);
            S.push(50);

            Console.WriteLine("Stack elements are : ");
            S.printStack();

            S.pop();
            S.pop();
            S.pop();
        }
    }

    class Stack
    {
        private int[] elements;
        private int top;
        private int max;

        public Stack(int size)
        {
            elements = new int[size];
            top = -1;
            max = size;
        }

        public void push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                elements[++top] = item;
            }
        }

        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Popped element is: " + elements[top]);
                return elements[top--];
            }
        }

        public void printStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]" + elements[i]);
                }
            }
        }
    }
}

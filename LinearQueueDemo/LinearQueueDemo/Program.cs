using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearQueueDemo
{
    /* Linear Queue follows FIFO (First In First Out) property, it means first inserted elements, deleted first. 
     * In linear queue there are two pointers are used:
        FRONT:	It points the location from where we can delete an item from linear queue.
        REAR:	It points the location from where we can insert element into linear queue.
    * */
    
    // Linear queue implementation using array
    class Program
    {
        static void Main(string[] args)
        {
            Queue Q = new Queue(5);

            Q.insert(10);
            Q.insert(20);
            Q.insert(30);
            Q.insert(40);
            Q.insert(50);

            Console.WriteLine("Elements in the queue are : ");
            Q.printQueue();

            Q.delete();
            Q.delete();

            Console.WriteLine("Elements in the queue are : ");
            Q.printQueue();
        }
    }

    class Queue
    {
        private int[] elements;
        private int front;
        private int rear;
        private int max;

        public Queue(int size)
        {
            elements = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }

        public void insert(int item)
        {
            if(rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                elements[++rear] = item;
            }
        }

        public int delete()
        {
            if(front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("deleted element is: " + elements[front]);
                return elements[front++];
            }
        }

        public void printQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for(int i = front; i <= rear; i++)
                {
                    Console.WriteLine("Element[" + (i + 1) + "]: " + elements[i]);
                }
            }
        }
    }
}

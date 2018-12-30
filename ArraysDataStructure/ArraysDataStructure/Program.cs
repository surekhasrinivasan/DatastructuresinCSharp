using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDataStructure
{
    // Arrays is used to store a collection of data. 
    // It stores a fixed-size sequential collection of elements of the same type. 
    // A specific element in an array is accessed by an index. 

    class Program
    {
        static void Main(string[] args)
        {
            // Defining Array
            int[] arr1 = new int[5];
            arr1[0] = 10;
            arr1[1] = 20;
            arr1[2] = 30;
            arr1[3] = 40;
            arr1[4] = 50;

            // inline array
            int[] arr2 = new int[5] { 10, 20, 30, 40, 50 };

            int[] arr3 = new int[] { 10, 20, 30, 40, 50, 60, 70 };

            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }

            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }

            foreach (int i in arr3)
            {
                Console.WriteLine(i);
            }            
        }
    }
}

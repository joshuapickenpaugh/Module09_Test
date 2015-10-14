//Josha Pickenpaugh, IN2017
//October 14th, 2015
//In Class Coding.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module09_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array:
            int[] array1 = { 3, 4, 33, 4, 5, 112, 1, 12, 1, 21, 2, 12, 43, 54, 215, 3, 5, 2, 46, 57 };
            displayArray(array1);
            Console.WriteLine();

            //Queue:
            Queue first = new Queue();
            first.Enqueue(7);
            first.Enqueue(722);
            first.Enqueue(45);
            first.Enqueue(16);
            Console.WriteLine("Que value: {0}", first.Count);
            first.Dequeue();
            Console.WriteLine("Que value after a dequeue: {0}", (int) first.Peek());

            //Halts console window:
            Console.ReadKey();
        }

        //Displays array location and values:
        public static void displayArray(int[] ary)
        {
            for (int i = 0; i < ary.Length; i++)
            {
                Console.WriteLine("{0} = {1}", i, ary[i]);
            }
        }
    }
}

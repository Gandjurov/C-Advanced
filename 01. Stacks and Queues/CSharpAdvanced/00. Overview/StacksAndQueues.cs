using System;
using System.Collections.Generic;

namespace StacksAndQueues
{
    class StacksAndQueues
    {
        static void Main(string[] args)
        {

            // ----------------------- Stacks -------------------------
            //  Stack<T> - LIFO data structure:
            //  stack<T> holds a stack of elements:
            //      Count - the number of elements in the Stack<T>
            //      Peek() - checks the value of the last added element
            //      Pop() - returns the last element and removes it from the stack
            //      Push() - adds an element to the Stack<T>
            //      ToArray() - converts stack to array
            //      Contains() - determines whether an element is in the stack
            //      Clear() - clear all elements in the stack

            Stack<int> numbers = new Stack<int>();

            //Push()
            numbers.Push(5);
            numbers.Push(10);
            numbers.Push(2);

            //Peek()
            int currentNumber = numbers.Peek();
            Console.WriteLine(currentNumber);

            //Pop()
            int lastNumber = numbers.Pop();
            Console.WriteLine($"Last number: {lastNumber}");

            currentNumber = numbers.Peek();
            Console.WriteLine($"Numbers peek: {currentNumber}");

            //Count
            Console.WriteLine($"Total in stack: {numbers.Count}");

            //Contains()
            bool hasEleven = numbers.Contains(11);
            bool hasTen = numbers.Contains(10);

            Console.WriteLine($"Has 11: {hasEleven}");
            Console.WriteLine($"Has 10: {hasTen}");

            //ToArray()

            int[] arrayFromStack = numbers.ToArray();

            foreach (var number in arrayFromStack)
            {
                Console.WriteLine(number);
            }

            //Clear()
            numbers.Clear();


            // ----------------------- Queues -------------------------

            //  Queue<T> - FIFO Data structure
            //  Queue<T> holds a queue of elements:
            //      Enqueue() - adds an element at the end of the queue
            //      Dequeue() - removes the first element and returns it
            //      Count - returns the number of elements in the queue
            //      Peek() - checks the value of the first element
            //      ToArray() - converts the queue to an array
            //      Contains() - check whether an alement is in the queue

            Queue<string> texts = new Queue<string>();

            //Enqueue
            texts.Enqueue("First");
            texts.Enqueue("Second");
            texts.Enqueue("Third");

            //Peek()
            string currentText = texts.Peek();

            Console.WriteLine(currentText); // return First

            //Dequeue()
            string firstElement = texts.Dequeue(); // return First
            firstElement = texts.Dequeue(); // return Second

            Console.WriteLine(firstElement);

            texts.Enqueue("Last One");

            //ToArray()
            string[] textAsArray = texts.ToArray();

            bool hasFirst = texts.Contains("First"); // False
            bool hasLast = texts.Contains("Last One"); // True 

            Console.WriteLine($"Has first: {hasFirst}");
            Console.WriteLine($"Has last: {hasLast}");

            //Clear()
            texts.Clear();
        }
    }
}

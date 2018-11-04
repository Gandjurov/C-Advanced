using System;
using System.Linq;
using System.Collections.Generic;

namespace Overview
{
    class Overview
    {
        public static void Main(string[] args)
        { 
            //lambda expressions:

            //A lambda expression is an anonymous function containing expressions and statements

            //Lambda syntax:
            // (parameters) => {body}
            //Use the lambda operator "=>", read as "goes to"
            //Paramenters can be enclosed in parentheses()
            //The body holds the expression or statement and can be enclosed in braces {}

            //Implicit lambda expression:
            //msg => Console.WriteLine(msg);

            //Explicit lambda expression:
            //(string msg) => { Console.WriteLine(msg); }

            //Zero parameters
            //() => { Console.WriteLine("Hi"); }

            //More Parameters
            //(int x, int y) => { return x + y; }


            //-------------------------------------------
            //Delegates

            //A delegate is a type that represents references to methods with a particular parameter list and return type
            //Used to pass methods and arguments to other methods
            //Can be used to define callback methods

            

            //-------------------------------------------
            //Generic Delegate - Func<T>:
            Func<int, string> func = n => n.ToString();
            //Input and output type can be different type
            //Input and output type must be from type which we declare them
            //Func generic delegate use type parameters to define the number and types of input parameters, and the return type of the delegate


            Func<int, int, string> opMulti = IsGreater;
            Console.WriteLine(Calculator(4, 5, Multiply));
            Console.WriteLine(Calculator(4, 5, Add));
            Console.WriteLine(Calculator(4, 5, IsGreater));
            Console.WriteLine(Calculator(21, 3, (x, y) => (x / y).ToString()));


            //Generic Delegate - Action<T>:
            //  In .NET Action<T> is a void method:

            //private void Print(string message)
            //{ Console.WriteLine(message); }

            //  Instead of writing the method we can do:
            // Action<string> print = message => Console.WriteLine(message);



            //Extention Methods:

            var set = new HashSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);

            set.ForEach(n => Console.WriteLine(n));

            var stringSet = new HashSet<string>();

            stringSet.ForEach(n => n.Trim());

            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.ForEach(n => Console.WriteLine(n));

            //------------------------------------------
            string text = "--text---";

            var result = text.TrimDashes();

            Console.WriteLine(result);

            
        }

        public static int WrongFunction(int x, int y)
        {
            return x + y;
        }

        public static string Calculator(int x, int y, Func<int, int, string> opr)
        {
            return opr(x, y);
        }

        public static string Multiply(int x, int y) => (x * y).ToString();

        public static string Add(int x, int y)
        {
            return (x + y).ToString();
        }

        public static string IsGreater(int x, int y)
        {
            return (x > y).ToString();
        }

        public delegate int Multiplier(int x, int y);
        Multiplier calc = (x, y) => x * y;
    }
}

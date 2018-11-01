using System;

namespace Overview
{
    class Overview
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            //if (text == "Pesho")
            //{
            //    throw new Exception("Pesho is invalid");
            //}

            //StackTrace:
            //Print();

            try
            {
                Console.WriteLine(int.Parse(text));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Argument exception");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch
            {
                Console.WriteLine("Test");
            }
            finally
            {
                Console.WriteLine("GoodBye!");
            }

            //try
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());

            //    Console.WriteLine(CalculatePositiveNumbers(a, b));
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid numbers!");
            //}
            //catch(ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Thank you for...");
            //}
        }

        //public static void Print()
        //{
        //    Calculate();
        //}

        //public static void Calculate()
        //{
        //    Error();
        //}

        //public static void Error()
        //{
        //    throw new Exception();
        //}

        public static int CalculatePositiveNumbers(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                Console.WriteLine("A and B cannot be less than zero!");
            }

            return a + b;
        }
    }
}

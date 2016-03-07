using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources05
{
    class Tasks
    {
        private static double DoubleParseInput( string message)
        {
            double result;
            do
            {
                Console.WriteLine(message);
            }
            while (!Double.TryParse(Console.ReadLine(), out result));
            return result;
        }

       public static void Task1()
        {
            double x = DoubleParseInput("Введите А");
            double y = DoubleParseInput("Введите Б");
            Console.WriteLine("{0} + {1} = {2}", x, y, NewCalc.Plus(x, y));
            Console.WriteLine("{0} - {1} = {2}", x, y, NewCalc.Minus(x, y));
            Console.WriteLine("{0} * {1} = {2}", x, y, NewCalc.Multiply(x, y));
            Console.WriteLine("{0} / {1} = {2}", x, y, NewCalc.Divide(x, y));
            Console.WriteLine("{0} ^ {1} = {2}", x, y, NewCalc.Pow(x, y));
            Console.WriteLine("Sqrt( {0} )= {1}", x,  NewCalc.Sqrt(x));
            Console.WriteLine("Sqrt( {0} )= {1}", y, NewCalc.Sqrt(y));

        }
       public static void Task2()
        {
            int[] testvalues = { 1, 6, 2, 65, 65, 2, 3, 534, 2, 353, 576, 12, 45, 24, 65 };
            testvalues.Sort(false);
            testvalues.Print();
        }
       public static void Task3()
        {
            Console.WriteLine();
            int[] testvalues = { 1, 6, 2, 65, 65, 2, 3, 534, 2, 353, 576, 12, 45, 24, 65 };
            testvalues.Sort(false);
            testvalues.Print();

        }
       public static void Task4()
        {
            string teststring;

            teststring = "eating cookies...";
            Console.WriteLine(teststring.LocalSubstring(7,7));

            teststring = "symbol 'A' is here!";
            Console.WriteLine(teststring.LocalIndexOf("is"));

            teststring = "aabb aaababa test string";
           Console.WriteLine(teststring.LocalReplace("test ", ""));


        }
    }
}

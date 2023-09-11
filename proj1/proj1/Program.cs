using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj1
{
    class Program
    {
        static int a, b;
        public static void equal()
        {
            WriteLine(" enter the number1");
            a = Convert.ToInt32(Console.ReadLine());
            WriteLine("enter the number2");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                WriteLine(" equal");
            }
            else
            {
                WriteLine(" not equal");
            }

        }
        public static void negative(params int[] args)
        {
            foreach (int i in args)
            {
                if (i < 0)
                {
                    WriteLine($" {i} is negative ");
                }
                else
                {
                    WriteLine($" {i} is positive ");
                }
            }
        }
        public void iteration()

        {
            WriteLine("start ");
            int ? i = 0;
            int ? str = 0;
            for (i = 10;str!=0;i++)
            {
                str = Convert.ToInt32(ReadLine());
                str += str;
            }
        }
        public static void operation()
        {
            WriteLine(" enter the values for operation");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int add = a + b;
            int sub = a - b;
            int multiplication = a * b;
            float division = a / b;
            WriteLine($"sum {add} difference {sub} product {multiplication} division {division}");
        }
        static void Main(string[] args)
        {
            ////equal();
            ////operation();
            //negative(1, 2);
            Program p1 = new Program();
            p1.iteration();

            Read();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebasetest_4
{
    class Delegates_test
    {
        public static int add(int a, int b) => a + b;
        public static int sub(int a, int b) => a - b;
        public static int muliplication(int a, int b) => a * b;
        public static int Divi(int a, int b)
        {
            return a / b;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("ENTER YOUR OPERATION");
            Console.WriteLine("1.ADDITION");
            Console.WriteLine("2.DIFFERENCE");
            Console.WriteLine("3.MULTIPLICATION");
            Console.WriteLine("4.DIVISION");
            
           int c =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("ENTER NUMBER1");
           int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER NUMBER2");
           int y = Convert.ToInt32(Console.ReadLine());
            Func<int, int, int> fs;
            switch (c)
            {
                case 1:fs = add;
                    Console.WriteLine(fs(x,y));
                    break;
                case 2:
                     fs = sub;
                    Console.WriteLine(fs(x, y));
                    break;
                case 3:
                    fs =muliplication;
                    Console.WriteLine(fs(x, y));
                    break;
                case 4:
                    fs = Divi;
                    Console.WriteLine(fs(x, y));
                    break;
                default: Console.WriteLine("INVALID OPTION");
                    break;

            }
            Console.ReadLine();
        }
    }
}

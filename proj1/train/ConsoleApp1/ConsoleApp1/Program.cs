using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
       static int ID,i;
        String Name;
        int SALARY;
        Employee s1 = new Employee();
        Employee s2 = new Employee();
        public static void ref_method(ref  int i)
        {
            i= 100;
            WriteLine($" {i} ");
        }
        public static int Calculate(int a,int b,out int sum,out int diff,out int prod,out float divi)
        {
            sum = a + b;
            diff = a - b;
            prod = a * b;
            divi = a / b;
            return 0;
            
        }
        public static void Value(int j)
        {
           // j = 100;
            WriteLine(" {0} ", j);
        }
       public static int para_meter(params int[] args)
        {
            int sum = 0;
            foreach (int i in args)
            {
                sum += i;
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            Value(10);
            i = 10;
           ref_method( ref i);
            WriteLine($" {i} ");
            int total = 0, d = 0, p = 0;
            float di = 0;
           Calculate(10, 5, out total, out d, out p, out di);
            WriteLine("{0} {1} {2} {3}", total, d, p, di);
            WriteLine("enter the input to total");
            ReadLine();
            int total1 = para_meter(1,2,3,4,5,6,7,8);
            WriteLine(" {0} ",total1);
            Read();
        }
       
    }
}

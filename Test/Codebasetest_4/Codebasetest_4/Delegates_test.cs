using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int CalculatorOperation(int num1, int num2);

class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    public int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    public int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
}

class Delegates_test
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Select an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("Enter choice");
        char c = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter number1:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number2:");
        int n2 = Convert.ToInt32(Console.ReadLine());
        CalculatorOperation cc = null;
            switch (c)
            {
                case '1':
                    cc = calculator.Add;
                    Console.WriteLine(cc(n1, n2));
                    break;
                case '2':
                    cc = calculator.Subtract;
                    Console.WriteLine(cc(n1, n2));
                    break;
                case '3':
                    cc = calculator.Multiply;
                    Console.WriteLine(cc(n1, n2));
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    return;
            }
        Console.Read();
    }   
}

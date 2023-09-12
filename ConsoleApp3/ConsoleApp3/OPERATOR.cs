using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    struct Tabel
    {
        public int l, b;
        public Tabel(int x, int y)
        {
            l = x;
            b = y;
        }
        public Tabel(int x)
        {
            l=x;
            b = 0;
        }
        public void area()
        {
            Console.WriteLine(l * b);
        }
    }
    class OPERATOR
    {
        public int dis;

        public OPERATOR(int dis)
        {
          this.dis = dis;
        
        }
        public static OPERATOR operator +(OPERATOR op1, OPERATOR op2)
        {
            OPERATOR temp = new OPERATOR(0);
            temp.dis = op1.dis + op2.dis;
            return temp;

        }
        public static OPERATOR operator ++(OPERATOR op1)
        {
            OPERATOR temp = new OPERATOR(0);
            temp.dis = op1.dis + 1;
            return temp;

        }
        public static void Main(String[] args)
        {
            OPERATOR op1 = new OPERATOR(90);
            OPERATOR op2 = new OPERATOR(100);
            //OPERATOR op3 = new OPERATOR();
            OPERATOR op3 = new OPERATOR(0);
                op3=op1 + op2;
            Console.WriteLine(op3);
            //op3 = op1++;
            //Console.Write(op3);
            ////op3.ShowData();
            Console.Read();
            Tabel(1, 2);

        }
    }
}

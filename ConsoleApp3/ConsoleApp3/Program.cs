using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        float fd;
        char w;
       static int id=20;
        public Program(float r,char y,int h)
        {
            fd = r;
            w = y;
            id = h;

        }
        static Program( )
        {
            id = 10;
        }
        static void Main(string[] args)
        {
            //    var v1 = 1;
            //    var v2 = 3;
            //    var v3 = 4;
            //    Console.WriteLine(v1+" "+v2+" "+v3);
            //    Console.Read();

            Program p2 = new Program(10.10f,'f',10);
            Console.WriteLine(p2.fd + " " + p2.w + " " + Program.id);
            Console.Read();

        }
    }
}

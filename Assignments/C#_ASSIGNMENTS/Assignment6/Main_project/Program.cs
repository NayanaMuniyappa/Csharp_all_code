using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conssession_Namespace;

namespace Main_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME");
            Console.WriteLine("ENTER NAME");
            string Name = Console.ReadLine();
            Console.WriteLine("PLEASE ENTER YOUR AGE OF PERSON");
            int AGE = Convert.ToInt32(Console.ReadLine());
           

            Consession_class cc = new Consession_class();
            cc.Calculate_Consession(Name, AGE);
            Console.Read();
        }
    }
}

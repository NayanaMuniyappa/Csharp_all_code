using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conssession_Namespace
{
    public class Consession_class
    {
        public void Calculate_Consession(String Name,int age)
        {
            if(age<=5)
            {
                Console.WriteLine("Little Champs-Free ticket ");
                Console.WriteLine($"NAME={Name}\t::\tAGE={age}");
                Console.WriteLine("TICKET PRIZE ZERO RUPEES\n.................");
            }
            
            else
            if(age>60)
            {
                Console.WriteLine(" “ Senior Citizen” 30% OFFER ");
                Console.WriteLine($"NAME={Name}\t::\tAGE={age}");
                double prize =(500-(500 *0.3));
                Console.WriteLine($"TICKET PRIZE {prize} RUPEES\n...............");
            }
            else
            {
                Console.WriteLine("ADULT");
                Console.WriteLine($"NAME={Name}\t::\tAGE={age}");
                Console.WriteLine("TICKET PRIZE 500 RUPEES\n................");
            }
        }
    }
}

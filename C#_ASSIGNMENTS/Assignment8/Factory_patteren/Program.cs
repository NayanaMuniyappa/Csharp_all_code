using Factory_patteren;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter card type :");
            string shapetype = Console.ReadLine();

            Ishape cc = factoryshapes.Getshape(shapetype);

            
            if(cc!=null)
            {
                Console.WriteLine("Card Type : {0}", cc.Getshapetype());
                Console.WriteLine("Card Limit : {0}", cc.Getarea());
                
            }
            else
            {
                Console.WriteLine("Invalid Card.. please give correct type");
            }
            Console.Read();
        }
    }
}

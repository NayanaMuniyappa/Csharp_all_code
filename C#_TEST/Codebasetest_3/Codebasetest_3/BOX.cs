using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a class Box that has Length and breadth as its members. 
 * Write a function that adds 2 box objects and stores in the 3rd. 
 * Display the 3rd object details. Create a Test class to execute the above.
 * */

namespace Codebasetest_3
{
    class BOX
    {
        public int LENGTH, BREADTH;
        public BOX(int LENGTH,int BREADTH)
        {
            this.LENGTH = LENGTH;
            this.BREADTH = BREADTH;
        }
        public static BOX  ADD_BOX(BOX A,BOX B)
        {
            int LENGTH_TOTAL = A.LENGTH + B.LENGTH;
            int BREADTH_TOTAL = A.BREADTH + B.BREADTH;
            BOX C = new BOX(LENGTH_TOTAL, BREADTH_TOTAL);
            return C;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE LENTH AND BREADTH OF 1ST BOX");
            int L1 = Convert.ToInt32(Console.ReadLine());
            int B1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE LENTH AND BREADTH OF 2ND BOX");
            int L2 = Convert.ToInt32(Console.ReadLine());
            int B2 = Convert.ToInt32(Console.ReadLine());
            BOX BOX1 = new BOX(L1, B1);
            BOX BOX2 = new BOX(L2, B2);
            BOX BOX3 = ADD_BOX(BOX1, BOX2);
            Console.WriteLine($" TOTAL_LENGTH BOX 3={BOX3.LENGTH} TOTAL_BREADTH BOX3={BOX3.BREADTH}");
            Console.Read();
        }
    }
}

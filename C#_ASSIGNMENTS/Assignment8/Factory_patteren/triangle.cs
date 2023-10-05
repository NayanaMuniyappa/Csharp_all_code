using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_patteren
{
    class triangle:Ishape
    {
        public int Getarea()
        {
            return 400;
        }



        public string Getshapetype()
        {
            return "Triangle";
        }

    }
}


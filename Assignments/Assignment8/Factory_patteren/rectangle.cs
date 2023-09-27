using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_patteren
{
    class rectangle:Ishape
    {


        public int Getarea()
        {
            return 600;
        }



        public string Getshapetype()
        {
            return "Rectangle";
        }
    }
}




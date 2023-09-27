using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_patteren
{
    class circle:Ishape
    {
        
      
            public int Getarea()
            {
                return 500;
            }

         

            public string Getshapetype()
            {
                return "circle";
            }
        
    }
}


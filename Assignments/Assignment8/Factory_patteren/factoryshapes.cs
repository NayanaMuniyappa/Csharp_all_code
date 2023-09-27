using Factory_patteren;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class factoryshapes
    {
        public static Ishape Getshape(string shape)
        {
            Ishape Icc = null;
            if (shape == "circle")
            {
                Icc = new circle();
            }
            else if (shape == "Rectangle")
            {
                Icc = new rectangle();
            }
            else if (shape == "Triangle")
            {
                Icc = new triangle();
            }
            return Icc;
        }
    }
}
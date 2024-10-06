using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatianal.Factory
{
    public static class Factory_of_Shape
    {

        public static Shape CreateShape(string value)
        {
            if (value=="Square")
            {
                return new Square();
            }
            if (value=="Circle")
            {
                return new Circle();
            }
            return null;
        }
    }
}

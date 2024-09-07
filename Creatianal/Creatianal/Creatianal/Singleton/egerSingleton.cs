using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatianal.Singleton
{
    public class egerSingleton
    {
        public static egerSingleton instance=new egerSingleton();

        public static egerSingleton get()
        { 
            return instance;
        }

    }
}

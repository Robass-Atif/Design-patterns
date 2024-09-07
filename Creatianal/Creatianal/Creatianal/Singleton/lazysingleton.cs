using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatianal.Singleton
{
   public  class lazysingleton


    {
       

        private static lazysingleton instance;

        public static lazysingleton GetLazysingleton()
        { 
            if(instance == null)
            {
                instance = new lazysingleton();
            }
            return instance;

        }



        

    }
}

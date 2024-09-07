using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Creatianal.Singleton;




namespace Creatianal
{
    internal class Program
    {
        static void Main(string[] args)

        {
            lazysingleton heloo=lazysingleton.GetLazysingleton();
            lazysingleton bye = lazysingleton.GetLazysingleton();

            Console.WriteLine(heloo.GetHashCode());
            Console.WriteLine(bye.GetHashCode());


            egerSingleton first = egerSingleton.get();
            Console.WriteLine(first.GetHashCode());
            egerSingleton second = egerSingleton.get();
            Console.WriteLine(second.GetHashCode());
            Console.ReadKey();
            




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Creatianal.Singleton;
using Creatianal.Factory;
using Creatianal.Builder;
using Creatianal.Prototype;




namespace Creatianal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prototype design pattern

            Vehicle vehicle=new Vehicle(100, "Car");
            Console.WriteLine(vehicle.name);
              Vehicle v2 =   vehicle.Clone();
            v2.name = "a";
            Console.WriteLine(v2.name);
            Console.WriteLine(vehicle.name);





            //Builder Design Pattern

            //Student student=new Student.Builder().SetSurname("Kaya").SetAge(20).SetAddress("Istanbul").SetEmail("as@gmail.com").build();
            //Console.WriteLine(student.tostring());


            //Factort Design Pattern
            //Shape Cicle = Factory_of_Shape.CreateShape("Circle");
            //Cicle.Area();

            //Shape Square = Factory_of_Shape.CreateShape("Square");
            //Square.Area();

            //Singleton Design Pattern

            //lazysingleton heloo=lazysingleton.GetLazysingleton();
            //lazysingleton bye = lazysingleton.GetLazysingleton();

            //Console.WriteLine(heloo.GetHashCode());
            //Console.WriteLine(bye.GetHashCode());


            //egerSingleton first = egerSingleton.get();
            //Console.WriteLine(first.GetHashCode());
            //egerSingleton second = egerSingleton.get();
            //Console.WriteLine(second.GetHashCode());
            Console.ReadKey();






        }
    }
}

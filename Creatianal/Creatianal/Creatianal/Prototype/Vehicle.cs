using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatianal.Prototype
{
    public class Vehicle:Car
    {
        public int speed;
        public string name;

        public Vehicle(int speed, string name)
        {
            this.speed = speed;
            this.name = name;

        }

        public  Vehicle Clone()
        {
            return new Vehicle(speed, name);
        }

    }

    public interface Car
    {
         Vehicle Clone();
    }
}

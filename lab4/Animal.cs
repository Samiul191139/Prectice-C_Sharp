using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animals make sounds.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Cow : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cow moos.");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows.");
        }
    }
}

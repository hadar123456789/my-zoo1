using System;
using System.Collections.Generic;
using System.Text;

namespace my_zoo1
{
    public class Cat: Animal
    {
        public override string SayHello()
        {
            return $"cat {Name} says: Meow!";
        }
    }
}

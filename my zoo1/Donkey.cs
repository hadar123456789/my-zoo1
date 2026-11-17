using System;
using System.Collections.Generic;
using System.Text;

namespace my_zoo1
{
    public class Donkey: Animal
    {
        public override string SayHello()
        {
            return $"donkey {Name} says: Hee-haw!";
        }
    }
}

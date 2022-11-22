using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class Cat:Animal
    {
        public Cat(string name):base(name) // base class ın constructı ezme işlemi
        {

        }
        public override void animalSound()
        {
            Console.WriteLine(name + " miyavlıyor");
        }

    }
}

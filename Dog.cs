using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class Dog:Animal //sub class
    {
        public Dog(string name):base(name) // base class ın constructı ezme işlemi
        {
           
        }
     
        public override void animalSound()
        {
            Console.WriteLine(name +" "+ "miyavlıyor");
        }

    }
}

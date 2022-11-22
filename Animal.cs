using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class Animal //base class
    {
        public string name { get; set; }
        public string _Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = name;
            }
        }     
        public Animal(string name)
        {
            this.name = name;
        }
        public virtual void animalSound()
        {
            Console.WriteLine("Hayvan Konuşuyor");
        }
    }
}

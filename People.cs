using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class People
    {
        public virtual void selamVer()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Title = " Polymorphsim";
            DateTime zaman = DateTime.Now;
            Console.WriteLine(zaman);
            Console.WriteLine("Aylardan Kasım");
        }
    }
    public class Türk : People
    {
        public override void selamVer()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Title = "Çılgın Türkler";
            Console.WriteLine("Selamın Aleyküm");
        }
    }
    public class Portugal : People
    {
        public override void selamVer()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Portekiz Selamlama");
            Console.WriteLine("nensino médio");
        }
    }
    public class Espana : People
    {
        public override void selamVer()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("ispanyolca Selamlar..");
            Console.WriteLine("escuela secundaria");
        }
    }
}

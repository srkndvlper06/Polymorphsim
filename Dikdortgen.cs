using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class Dikdortgen:Sekil
    {
        public int kısakenar { get; set; }
        public int uzunkenar { get; set; }
        public Dikdortgen(string name, int kısakenar, int uzunkenar) : base(name)
        {
            this.kısakenar = kısakenar;
            this.uzunkenar = uzunkenar;
        }
        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(NAME+" "+"nin alanı"+(kısakenar*uzunkenar));
        }
        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine("şeklin ismi"+NAME);
            Console.WriteLine(NAME+"nin kısa kenarı"+this.kısakenar);
            Console.WriteLine(NAME + "nin uzun kenarı" + this.uzunkenar);
        }
    }
}

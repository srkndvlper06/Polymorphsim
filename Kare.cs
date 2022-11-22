using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class Kare:Sekil
    {
        public int kenar { get; set; }
        public Kare(string name,int kenar ):base(name)
        {
            this.kenar = kenar;
        }
        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(NAME+" "+"nin alanı"+(kenar*kenar));
        }
        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine(NAME + "nin kenar" + this.kenar);          
        }

    }
}

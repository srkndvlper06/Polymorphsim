using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class Ucgen:Sekil
    {
        public int tabanalani { get; set; }
        public int yükseklik { get; set; }
        public Ucgen(string name,int tabanalani,int yükseklik):base(name)
        {
            this.tabanalani = tabanalani;
            this.yükseklik = yükseklik;
        }
        public override void sekilHesapla()
        {
            base.sekilHesapla();
            Console.WriteLine(NAME+" "+"nin alanı"+(tabanalani*yükseklik)/2);
        }
        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine("şeklin ismi:"+NAME);
            Console.WriteLine(NAME + "nin tabanalanı" + this.tabanalani);
            Console.WriteLine(NAME + "nin yükseklik" + this.yükseklik);
        }
    }
}

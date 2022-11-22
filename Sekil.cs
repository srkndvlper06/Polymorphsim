using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public class Sekil //base class
    {
        public string name { get; set; }
        public Sekil(string name)
        {
            this.name= name;
        }
        public string NAME
        {
            get
            {
                return name;
            }
        }
        public virtual void sekilHesapla()
        {
            Console.WriteLine("Şekil Alanı Hesaplanıyor");
        }
        public virtual void sekilBilgileriGoster()
        {
            Console.WriteLine(NAME+" "+"nin Bilgileri..!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PolymorphsimOne;
            //polymorphsim ve constructer yapıları ile proje
            /*Animal anml = new Animal("Hayvan");
             anml.animalSound();
             Dog dg = new Dog("karabas");
             dg.animalSound();
             Cat ct = new Cat("minnoş");
             ct.animalSound();
             hayvanlarıKonustur(new Dog("karabaş"));
             hayvanlarıKonustur(new Cat("minnoş")); */
            #endregion

            #region PolymorphsimTwo;
            /* People insn = new People();
             insn.selamVer();
             Console.WriteLine("**********");
             Türk trk = new Türk();
             trk.selamVer();
             Console.WriteLine("**********");
             Portugal prtgl = new Portugal();
             prtgl.selamVer();
             Console.WriteLine("**********");
             Espana espn = new Espana();
             espn.selamVer();*/
            #endregion

            #region PolymorphsimThree;
            /* Console.WriteLine("Şekil Uygulamasına Hoşgeldiniz");
             while (true)
             {
                 Console.WriteLine("İşlem Seçiniz");
                 Console.WriteLine("1- Dikdörtgen İşlemleri");
                 Console.WriteLine("2- Üçgen İşlemleri");
                 Console.WriteLine("3- Kare İşlemleri");
                 Console.WriteLine("4- q/ya basarak çıkınız");
                 string secim = Console.ReadLine();

                 if (secim == "q")
                 {
                     break;
                 }
                 else if (secim == "1")
                 {
                     while (true)
                     {
                         Console.WriteLine("1- Dikdörtgen alan hesapla");
                         Console.WriteLine("2- Dikdörtgen bilgileri göster");
                         Console.WriteLine("3- Çıkış yapın");
                         string secimDikdörtgen = Console.ReadLine();
                         if (secimDikdörtgen == "1")
                         {
                             Console.WriteLine("Dikdörtgenin kısa kenarını girin");
                             int kısakenar = Convert.ToInt32(Console.ReadLine());
                             Console.WriteLine("Dikdörtgenin uzun kenarını girin");
                             int uzunkenar = Convert.ToInt32(Console.ReadLine());
                             Dikdortgen dkdrtgn = new Dikdortgen("Dikdörtgen", kısakenar, uzunkenar);
                             dkdrtgn.sekilHesapla();
                         }
                         else if (secimDikdörtgen == "2")
                         {
                             Console.WriteLine("Dikdörtgenin kısa kenarını girin");
                             int kısakenar = Convert.ToInt32(Console.ReadLine());
                             Console.WriteLine("Dikdörtgenin uzun kenarını girin");
                             int uzunkenar = Convert.ToInt32(Console.ReadLine());
                             Dikdortgen dkdrtgn = new Dikdortgen("dikdörtgen", kısakenar, uzunkenar);
                             dkdrtgn.sekilBilgileriGoster();
                         }
                         else if (secimDikdörtgen == "3")
                         {
                             Console.WriteLine("dikdörtgen uygulamasından çıkılıyor");
                             break;
                         }
                     }
                 }
                 else if (secim == "2")
                 {
                     while (true)
                     {
                         Console.WriteLine("1- Üçgenin alan hesapla");
                         Console.WriteLine("2- Üçgenin bilgileri göster");
                         Console.WriteLine("3- Çıkış yapın");
                         string secimUcgen = Console.ReadLine();
                         if (secimUcgen == "1")
                         {
                             Console.WriteLine("Üçgenin tabanı girin");
                             int taban = Convert.ToInt32(Console.ReadLine());
                             Console.WriteLine("Üçgenin yüksekliğini girin");
                             int yükseklik = Convert.ToInt32(Console.ReadLine());
                             Ucgen ucgn = new Ucgen("Üçgen", taban, yükseklik);
                             ucgn.sekilHesapla();
                         }
                         else if (secimUcgen == "2")
                         {
                             Console.WriteLine("Üçgenin tabanı girin");
                             int taban = Convert.ToInt32(Console.ReadLine());
                             Console.WriteLine("üçgenin yüksekliğini girin");
                             int yükseklik = Convert.ToInt32(Console.ReadLine());
                             Ucgen ucgn = new Ucgen("Üçgen", taban, yükseklik);
                             ucgn.sekilBilgileriGoster();
                         }
                         else if (secimUcgen == "3")
                         {
                             Console.WriteLine("üçgen uygulamasından çıkılıyor");
                             break;
                         }
                     }
                 }
                 else if (secim == "3")
                 {
                     while (true)
                     {
                         Console.WriteLine("1- Karenin alanını hesapla");
                         Console.WriteLine("2- Karenin bilgileri göster");
                         Console.WriteLine("3- Çıkış yapın");
                         string secimKare = Console.ReadLine();
                         if (secimKare == "1")
                         {
                             Console.WriteLine("Karenin kenarını girin");
                             int kenar = Convert.ToInt32(Console.ReadLine());
                             Kare kr = new Kare("Kare", kenar);
                             kr.sekilHesapla();
                         }
                         else if (secimKare == "2")
                         {
                             Console.WriteLine("karenin kenarını girin");
                             int kenar = Convert.ToInt32(Console.ReadLine());
                             Kare kr = new Kare("kare", kenar);
                             kr.sekilBilgileriGoster();
                         }
                         else if (secimKare == "3")
                         {
                             Console.WriteLine("kare uygulamasından çıkılıyor");
                             break;
                         }
                     }
                 }
                 else
                 {
                     Console.WriteLine("Geçersiz bir değer girdiniz");
                 }
             }*/
            #endregion


            Console.WriteLine("hello world");





        }
        /* public static void hayvanlarıKonustur(Animal animal) //statik methot ile işlem kolaylığı sağlandı..
         {
           animal.animalSound();
         }*/
    }
}
